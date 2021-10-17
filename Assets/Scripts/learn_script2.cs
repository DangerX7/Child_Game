using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learn_script2 : MonoBehaviour
{

    private Rigidbody2D rb;
    bool clickStatus;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        rb.AddForce(transform.up * 20f);
    }
}