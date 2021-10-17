using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit_script : MonoBehaviour
{
    public GameObject ThisFruit;
    public void DeactivateObj()
    {
        ThisFruit.SetActive(false);
    }
}
