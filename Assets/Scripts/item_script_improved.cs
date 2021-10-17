using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_script_improved : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite barrel, sword, axe, book, crystal, lamp, garb, bow, armour;

    public int itemType;
    // Start is called before the first frame update


    public int CalculateSCheck(int oldSCheck)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4 };
        list.Remove(oldSCheck);
        int index = Random.Range(0, 4);
        return list[index];
    }

    void Start()
    {
        GameObject Master = GameObject.Find("MasterObject");
        Memory_script_improved memoryReference = Master.GetComponent<Memory_script_improved>();
        //  itemType = memoryReference.itemTypeCheck;
        //   Debug.Log(itemType);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateType();
    }

    public static List<int> GetTypes(int nPairs)
    {
        List<int> list = new List<int>();
        int index = Random.Range(1, 8);
        for (int i = 0; i < nPairs; i++)
        {
            while (list.Contains(index))
            {
                index = Random.Range(1, 8);
            }
            list.Add(index);
            list.Add(index);
            Debug.Log("list " + index);
        }
        return list;
    }


    // to do switch
    public void UpdateType()
    {
        if (itemType == 0)
        {
            spriteRenderer.sprite = barrel;
        }
        if (itemType == 1)
        {
            spriteRenderer.sprite = sword;
        }
        if (itemType == 2)
        {
            spriteRenderer.sprite = axe;
        }
        if (itemType == 3)
        {
            spriteRenderer.sprite = book;
        }
        if (itemType == 4)
        {
            spriteRenderer.sprite = crystal;
        }
        if (itemType == 5)
        {
            spriteRenderer.sprite = lamp;
        }
        if (itemType == 6)
        {
            spriteRenderer.sprite = garb;
        }
        if (itemType == 7)
        {
            spriteRenderer.sprite = bow;
        }
        if (itemType == 8)
        {
            spriteRenderer.sprite = armour;
        }
    }
}
