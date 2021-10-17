using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class count_script : MonoBehaviour
{
    public GameObject Fruits;
    public int appleCount;
    public int bananaCount;
    public int orangeCount;
    public int pearCount;
    public int strawberryCount;
    public int countTarget;
    public int countType; // 1-apple,2-banana,3-orange,4-pear,5-strawberry

    IEnumerator CoroutineWait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main Menu");
    }

    public void AppleCountIncrease()
    {
        appleCount += 1;
    }
    public void bananaCountIncrease()
    {
        bananaCount += 1;
    }
    public void orangeCountIncrease()
    {
        orangeCount += 1;
    }
    public void pearCountIncrease()
    {
        pearCount += 1;
    }
    public void strawberryCountIncrease()
    {
        strawberryCount += 1;
    }

    public void Update()
    {
        if ((countType == 1) && (appleCount == countTarget))
        {
            Win();
        }
        if ((countType == 2) && (bananaCount == countTarget))
        {
            Win();
        }
        if ((countType == 3) && (orangeCount == countTarget))
        {
            Win();
        }
        if ((countType == 4) && (pearCount == countTarget))
        {
            Win();
        }
        if ((countType == 5) && (strawberryCount == countTarget))
        {
            Win();
        }
    }

    public void Win()
    {
        Fruits.SetActive(false);
        GameObject win = Instantiate(Resources.Load("win text")) as GameObject;
        win.transform.position = this.transform.position;
        countType = 0;
        StartCoroutine(CoroutineWait());
    }
}
