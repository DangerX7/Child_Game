using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class movement_joystick : MonoBehaviour
{
    public GameObject joystick, joystickBG;
    public Vector2 joystickVec;
    private Vector2 joystickTouchPos, joystickOriginalPos;
    private float joystickRadius;
    // Start is called before the first frame update
    void Start()
    {
        joystickOriginalPos = joystickBG.transform.position;
        joystickRadius = joystickBG.GetComponent<RectTransform>().sizeDelta.y / 4;
    }

    public void PointerDown()
    {
        joystick.transform.position = Input.mousePosition;
        joystickBG.transform.position = Input.mousePosition;
        joystickTouchPos = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData)
    {
        Debug.Log("drag");
        UnlockPlayerSpeed();
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVec = (dragPos - joystickTouchPos).normalized;

        float joystickDist = Vector2.Distance(dragPos, joystickTouchPos);

        if (joystickDist < joystickRadius)
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joystickDist;
        }

        else
        {
            joystick.transform.position = joystickTouchPos + joystickVec * joystickRadius;
        }
    }

    public void PointerUp()
    {
        joystickVec = Vector2.zero;
        joystick.transform.position = joystickOriginalPos;
        joystickBG.transform.position = joystickOriginalPos;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UnlockPlayerSpeed()
    {
        GameObject Robot = GameObject.Find("robot"); //refer player object
        robot_script speedReference = Robot.GetComponent<robot_script>(); // refer player script
        speedReference.speedLock = false; // unlock player speed
    }
}
