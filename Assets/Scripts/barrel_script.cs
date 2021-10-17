using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barrel_script : MonoBehaviour
{
    public int itemType; // 0 values counts as 2
    public bool countStop;

    public int barrelNumber;
  //  public bool imageActivate;
  //  public Image image;

    public void Start()
    {
    //    image = this.GetComponent<Image>();
   //     imageActivate = true;
    }

    public void Update()
    {
        if (countStop == true)
        {
            GetComponent<Button>().interactable = false;
        }
        if (countStop == false)
        {
            GetComponent<Button>().interactable = true;
        }

    //    if (imageActivate == false)
        {
    //        image.enabled = false;
        }
    //    if (imageActivate == true)
        {
    //        image.enabled = true;
        }

        GameObject Master = GameObject.Find("MasterObject");
        memory_script pairsReference = Master.GetComponent<memory_script>();
        if ((itemType == 1) && (pairsReference.pair1Count == -1))
        {
            this.transform.parent.gameObject.SetActive(false);
        }
        if ((itemType == 2) && (pairsReference.pair2Count == -1))
        {
            this.transform.parent.gameObject.SetActive(false);
        }
        if ((itemType == 3) && (pairsReference.pair3Count == -1))
        {
            this.transform.parent.gameObject.SetActive(false);
        }
        if ((itemType == 4) && (pairsReference.pair4Count == -1))
        {
            this.transform.parent.gameObject.SetActive(false);
        }
    }
}
