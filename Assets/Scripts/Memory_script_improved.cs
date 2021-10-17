using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Memory_script_improved : MonoBehaviour
{
    public GameObject[] items;
    // number of items / game types / 4,6,9,12,16

    public int itemPosRef = 1;

    public Vector3 itemPos = Vector3.zero;

    public int itemTypeCheck;

    public int phaseCheck = 1;

    public int z;

    public int nRows = 2;

    public int CalculateSCheck(int oldSCheck)
    {
        List<int> list = new List<int>() { 10, 20, 30, 40 };
        list.Remove(oldSCheck);
        int index = Random.Range(0, 3);
        return list[index];
    }

    void Start()
    {
        if (items.Length % nRows != 0)
        {
            throw new System.Exception();
        }

        List<int> types = item_script_improved.GetTypes(items.Length / 2);

        float marginH = Screen.currentResolution.width * 0.25f / 2;
        float marginV = Screen.currentResolution.height * 0.25f /2;

        float width = (float)Screen.currentResolution.width * 0.75f / (2 * (items.Length / nRows));
        float height = (float)Screen.currentResolution.height * 0.75f / (2 * nRows);

        for (int i = 0; i < items.Length; i++)
        {
            Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Item.prefab", typeof(GameObject));
            GameObject item = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
            item_script_improved typeReference = item.GetComponent<item_script_improved>();

            Debug.Log(Screen.currentResolution);

            float screenRatio = width / height;
            float x = (2 * (i % (items.Length / nRows)) + 1) * width + marginH;
            float y = (2 * (i / (items.Length / nRows)) + 1) * height + marginV;
            Vector3 itemPos = new Vector3 (x, y, 0);
            item.transform.position = itemPos;
            int typeIndex = Random.Range(0, types.Count - 1);
            int type = types[typeIndex];
            typeReference.itemType = type;
            Debug.Log("types " + types.Count);
            types.Remove(type);
         //   Debug.Log(0 % 3 + 1);

        /*
        if (items.Length == 4)
        {
           // if (phaseCheck == 1)
            {
        //        itemTypeCheck = CalculateSCheck(itemTypeCheck);
            }
           // if (phaseCheck == 2)
            {
          //      itemTypeCheck = CalculateSCheck(itemTypeCheck);
            }
          //  if (phaseCheck == 3)
            {
           //     itemTypeCheck = CalculateSCheck(itemTypeCheck);
            }
          //  if (phaseCheck == 4)
            {
          //      itemTypeCheck = CalculateSCheck(itemTypeCheck);
            }

            itemTypeCheck = CalculateSCheck(itemTypeCheck);
            Debug.Log("CHECK " + itemTypeCheck);
            //   Debug.Log("Player Number " + i + " is named " + items[i].name);

            Object prefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Item.prefab", typeof(GameObject));
            GameObject item = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;

            if (itemPosRef == 1)
            {
                itemPos = new Vector3(-3f, 3f, 0f);
            }
            if (itemPosRef == 2)
            {
                itemPos = new Vector3(3f, 3f, 0f);
            }
            if (itemPosRef == 3)
            {
                itemPos = new Vector3(-3f, -3f, 0f);
            }
            if (itemPosRef == 4)
            {
                itemPos = new Vector3(3f, -3f, 0f);
            }

            item.transform.position = this.transform.position + itemPos;

            itemPosRef++;
            phaseCheck++;
        }
    */
}
    }

        void Update()
    {

    }

}