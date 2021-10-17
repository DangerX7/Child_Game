using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger_codes : MonoBehaviour
{
    /*
    -----Check for collision with a tag

     if (col.gameObject.tag.Equals("Sound"))
    //////////////////////////////////////////////
    -----Check for collision with a game object name

    if (col.transform.gameObject.name == ("Sound"))
    //////////////////////////////////////////////
    -----Check for collision with a game object reference

      if (col.gameObject == S2x20)
    ///////////////////////////////////////////////
    -----Check for keyboard short press

    if (Input.GetKeyDown(KeyCode.T)
    ////////////////////////////////////////////
    -----Initiate Coroutine

    
    StartCoroutine(CoroutineWait());
    //////////////////////////////////////////////
    -----Create a Coroutine

    IEnumerator CoroutineWait()
    {
        yield return null;
        yield return new WaitForSeconds(0.001f);
        yield break;                                   //end coroutine
    }
    ////////////////////////////////////////////////
    -----reference to another script
    
    GameObject Master = GameObject.Find("MasterObject");
    master_script switchReference = Master.GetComponent<master_script>();
    ///////////////////////////////////////////////////
    -----To manually exit out of a function at any time, use the 'return' keyword.
    
            return;
    /////////////////////////////////////////////////////////////////
    -----check if object exists after name

    if (GameObject.Find("SceneUnlocker") != null)
    ///////////////////////////////////////////////////////////////
    -----check if referenced object exists

    if (enemies1 != null)
    ///////////////////////////////////////////////////////////
    -----check if parent is active

    if (gameObject.activeInHierarchy)
    ////////////////////////////////////////////////////
    -----check if object with the script exists

    if (gameObject.activeSelf)
    //////////////////////////////////////////////////////
    ---set sprite renderer and sprites

    public SpriteRenderer spriteRenderer;
    public Sprite up, down, left, right, win, lose, perfect_win;
    /////////////////////////////////////////////////////////
    -----change sprite

    spriteRenderer.sprite = down;
    //////////////////////////////////////////////////////////
    -----activate or deactivate object

    player.SetActive(true);
    //////////////////////////////////////////////////////////////
    -----destroy current object

    Destroy(this.gameObject);
    /////////////////////////////////////////////////////
    -----destroy all enemies with the same tag

    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
    foreach(GameObject enemy in enemies)
    GameObject.Destroy(enemy);
    /////////////////////////////////////////////////////
    -----add a new Vector3

    Vector3 temp = new Vector3(0, -0.04f, 0);
    ///////////////////////////////////////////////
    -----change object tag

    gameObject.tag = "ArmourEnemy";
    //////////////////////////////////////////////////
    -----assing new possition to certain game object
    
    spike.transform.position = originalPos;
    /////////////////////////////////////////////////////////
    -----find the game obbject by tag and make reference to object script variables 

    portal_master_object_script p;
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Var").GetComponent<portal_master_object_script>();
    }
        public void Update()
        {
            if (p.variablesReset == true)  //reset variables
            {
                moves = 0;
                isReverseTrue = false;
            }
        }
    //////////////////////////////////////////////////////////
    ---set a variable to a random value

    dirrection = Random.Range(0, 3);

    ///////////////////////////////////////////////////////////////////
    -call an function from another script

      SceneUnlocker.GetComponent<scene_unlocker_script>().VersusModeEnd();
    ///////////////////////////////////////////////////
    -load a scene

     SceneManager.LoadScene("Classic Map");
    //////////////////////////////////////////////////////////////
    -activate a child
    
     transform.GetChild(0).gameObject.SetActive(true);
    //////////////////////////////////////////////////////////////
    -reference parent object in child script

    GameObject Enemy = transform.parent.gameObject;
    //////////////////////////////////////////////////////////////////
    -check if animation ended

        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("animation_name"))
        {
            Debug.Log("Animation Ended!");
        }
    ////////////////////////////////////////////////////////////////////////////
    -dissable curent animation
    
        animator.gameObject.GetComponent<Animator>().enabled = false;
    ///////////////////////////////////////////////////////////////////
    -spawn an object from Resources

        GameObject Projectile1 = Instantiate(Resources.Load("projectile-B1DownF")) as GameObject;
        Projectile1.transform.position = spawn1;
    //////////////////////////////////////////////////////////////////////////////////////////////////
    -load scene by name

    SceneManager.LoadScene("1Main_Gate-1");
    /////////////////////////////////////////////////////////
     */
}
