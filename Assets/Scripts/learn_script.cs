using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class learn_script : MonoBehaviour
{
    public float baseMoveSpeed = 10f;
    float moveSpeed;


    public enum MoveSpeedType
    {
        Regular,
        Turbo
    }

    public void Start()
    {

    }
    public void FixedUpdate()
    {
        float playerMoveType;
        playerMoveType = (float)MoveSpeedType.Regular;

        switch (playerMoveType)
        {
            case (float)MoveSpeedType.Regular:
                moveSpeed = baseMoveSpeed;
                break;

            case (float)MoveSpeedType.Turbo:
                moveSpeed = baseMoveSpeed * 2;
                break;
        }

        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        bool held = Input.GetKey(KeyCode.Space);
        if (held)
        {
            playerMoveType = (float)MoveSpeedType.Turbo;
        }
        else
        {
            playerMoveType = (float)MoveSpeedType.Regular;
        }
        Debug.Log(moveSpeed);
    }
}