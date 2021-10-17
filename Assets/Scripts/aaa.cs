using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour
{

    public List<T> GetRandomFromList<T>(List<T> passedList, int numberToChoose)
    {
        System.Random rnd = new System.Random();
        List<T> chosenItems = new List<T>();

        for (int i = 1; i <= numberToChoose; i++)
        {
            int index = rnd.Next(passedList.Count);
            chosenItems.Add(passedList[index]);
        }

        //Debug.Log(chosenItems.Count);

        return chosenItems;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
