using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class robot_script : MonoBehaviour
{
    public GameObject Labyrinth, Joystick;

    public movement_joystick movementJoystick;
    private float playerSpeed;
    public float playerSpeedValue;
    public bool speedLock;
    private Rigidbody2D rb;
    public bool endCheck;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        playerSpeed = playerSpeedValue;
        rend = GetComponent<Renderer>();
    }
    IEnumerator CoroutineWait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main Menu");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
        }

        else
        {
            rb.velocity = Vector2.zero;
        }

        if (speedLock == false) // unlock player speed
        {
            playerSpeed = playerSpeedValue;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("wall")) // lock player speed
        {
            playerSpeed = 0;
            speedLock = true;
        }

        if ((collision.gameObject.tag.Equals("goal")) && (endCheck == false)) // level complete
        {
            Labyrinth.SetActive(false);
            Joystick.SetActive(false);
            rend.enabled = false;
            GameObject win = Instantiate(Resources.Load("win text")) as GameObject;
            win.transform.position = (this.transform.position) + (new Vector3(-0.65f, 4.0f, 0.0f));
        //    endCheck = true;
            StartCoroutine(CoroutineWait());
        }
    }
}
