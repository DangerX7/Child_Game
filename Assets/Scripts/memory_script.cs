using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class memory_script : MonoBehaviour
{
    public GameObject AdvanceButton, Item1aBarrel, Item1bBarrel, Item1cBarrel, Item2aBarrel, Item2bBarrel, Item2cBarrel, Item3aBarrel, Item3bBarrel, Item3cBarrel,
                                     Item1a, Item1b, Item1c, Item2a, Item2b, Item2c, Item3a, Item3b, Item3c,
                                     X1a, X1b, X1c, X2a, X2b, X2c, X3a, X3b, X3c, Items;

    Vector3 Item1aPos, Item1bPos, Item1cPos, Item2aPos, Item2bPos, Item2cPos, Item3aPos, Item3bPos, Item3cPos;

    public int count;
    public bool preventCountLimit;
    public int pair1Count;
    public bool pair1CountEnd;
    public int pair2Count;
    public bool pair2CountEnd;
    public int pair3Count;
    public bool pair3CountEnd;
    public int pair4Count;
    public bool pair4CountEnd;
    public bool endCheck;

    public bool imgCheck;
    private int pairsMade;
    public int pairsTarget; // Pairs Target 

    private float speed;
    public float step;
    public bool shuffleCheck;
    public int sCheck;
    public byte checkSwitch;

    public void Start()
    {
        if (pairsTarget >= 2)
        {
            Item1aPos = new Vector3(X1a.transform.position.x, X1a.transform.position.y, X1a.transform.position.z);
            Item1bPos = new Vector3(X1b.transform.position.x, X1b.transform.position.y, X1b.transform.position.z);
            Item2aPos = new Vector3(X2a.transform.position.x, X2a.transform.position.y, X2a.transform.position.z);
            Item2bPos = new Vector3(X2b.transform.position.x, X2b.transform.position.y, X2b.transform.position.z);
        }
        if (pairsTarget >= 3)
        {
            Item1cPos = new Vector3(X1c.transform.position.x, X1c.transform.position.y, X1c.transform.position.z);
            Item2cPos = new Vector3(X2c.transform.position.x, X2c.transform.position.y, X2c.transform.position.z);
        }
        if (pairsTarget >= 4)
        {
            Item3aPos = new Vector3(X3a.transform.position.x, X3a.transform.position.y, X3a.transform.position.z);
            Item3bPos = new Vector3(X3b.transform.position.x, X3b.transform.position.y, X3b.transform.position.z);
            Item3cPos = new Vector3(X3c.transform.position.x, X3c.transform.position.y, X3c.transform.position.z);
        }

    }
    IEnumerator CoroutineWait()
    {
        if (count == 2)
        {
            if (GameObject.Find("Barrel1a") != null)
            {
                GameObject Barrel1a = GameObject.Find("Barrel1a");
                barrel_script memoryReference1a = Barrel1a.GetComponent<barrel_script>();
                memoryReference1a.countStop = true;
            }
            Debug.Log("lock");
            if (GameObject.Find("Barrel1b") != null)
            {
                GameObject Barrel1b = GameObject.Find("Barrel1b");
                barrel_script memoryReference1b = Barrel1b.GetComponent<barrel_script>();
                memoryReference1b.countStop = true;
            }
            if (GameObject.Find("Barrel1c") != null)
            {
                GameObject Barrel1c = GameObject.Find("Barrel1c");
                barrel_script memoryReference1c = Barrel1c.GetComponent<barrel_script>();
                memoryReference1c.countStop = true;
            }
            if (GameObject.Find("Barrel2a") != null)
            {
                GameObject Barrel2a = GameObject.Find("Barrel2a");
                barrel_script memoryReference2a = Barrel2a.GetComponent<barrel_script>();
                memoryReference2a.countStop = true;
            }
            if (GameObject.Find("Barrel2b") != null)
            {
                GameObject Barrel2b = GameObject.Find("Barrel2b");
                barrel_script memoryReference2b = Barrel2b.GetComponent<barrel_script>();
                memoryReference2b.countStop = true;
            }
            if (GameObject.Find("Barrel2c") != null)
            {
                GameObject Barrel2c = GameObject.Find("Barrel2c");
                barrel_script memoryReference2c = Barrel2c.GetComponent<barrel_script>();
                memoryReference2c.countStop = true;
            }
            if (GameObject.Find("Barrel3a") != null)
            {
                GameObject Barrel3a = GameObject.Find("Barrel3a");
                barrel_script memoryReference3a = Barrel3a.GetComponent<barrel_script>();
                memoryReference3a.countStop = true;
            }
            if (GameObject.Find("Barrel3b") != null)
            {
                GameObject Barrel3b = GameObject.Find("Barrel3b");
                barrel_script memoryReference3b = Barrel3b.GetComponent<barrel_script>();
                memoryReference3b.countStop = true;
            }
            if (GameObject.Find("Barrel3c") != null)
            {
                GameObject Barrel3c = GameObject.Find("Barrel3c");
                barrel_script memoryReference3c = Barrel3c.GetComponent<barrel_script>();
                memoryReference3c.countStop = true;
            }
            count = -1;
        }
        yield return new WaitForSeconds(2);

        if (GameObject.Find("Barrel1a") != null)
        {
            GameObject Barrel1a = GameObject.Find("Barrel1a");
            barrel_script memoryReference1a = Barrel1a.GetComponent<barrel_script>();
        }
        Debug.Log("lock");
        if (GameObject.Find("Barrel1b") != null)
        {
            GameObject Barrel1b = GameObject.Find("Barrel1b");
            barrel_script memoryReference1b = Barrel1b.GetComponent<barrel_script>();
            memoryReference1b.countStop = true;
        }
        if (GameObject.Find("Barrel1c") != null)
        {
            GameObject Barrel1c = GameObject.Find("Barrel1c");
            barrel_script memoryReference1c = Barrel1c.GetComponent<barrel_script>();
            memoryReference1c.countStop = true;
        }
        if (GameObject.Find("Barrel2a") != null)
        {
            GameObject Barrel2a = GameObject.Find("Barrel2a");
            barrel_script memoryReference2a = Barrel2a.GetComponent<barrel_script>();
            memoryReference2a.countStop = true;
        }
        if (GameObject.Find("Barrel2b") != null)
        {
            GameObject Barrel2b = GameObject.Find("Barrel2b");
            barrel_script memoryReference2b = Barrel2b.GetComponent<barrel_script>();
            memoryReference2b.countStop = true;
        }
        if (GameObject.Find("Barrel2c") != null)
        {
            GameObject Barrel2c = GameObject.Find("Barrel2c");
            barrel_script memoryReference2c = Barrel2c.GetComponent<barrel_script>();
            memoryReference2c.countStop = true;
        }
        if (GameObject.Find("Barrel3a") != null)
        {
            GameObject Barrel3a = GameObject.Find("Barrel3a");
            barrel_script memoryReference3a = Barrel3a.GetComponent<barrel_script>();
            memoryReference3a.countStop = true;
        }
        if (GameObject.Find("Barrel3b") != null)
        {
            GameObject Barrel3b = GameObject.Find("Barrel3b");
            barrel_script memoryReference3b = Barrel3b.GetComponent<barrel_script>();
            memoryReference3b.countStop = true;
        }
        if (GameObject.Find("Barrel3c") != null)
        {
            GameObject Barrel3c = GameObject.Find("Barrel3c");
            barrel_script memoryReference3c = Barrel3c.GetComponent<barrel_script>();
            memoryReference3c.countStop = true;
        }
        BarrelSwap();
    }

    IEnumerator CoroutineEndWait()
    {
        yield return new WaitForSeconds(1);
        Items.SetActive(false);
        GameObject win = Instantiate(Resources.Load("win text")) as GameObject;
        win.transform.position = this.transform.position;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main Menu");
    }
    IEnumerator CoroutineShuffle()
    {
        switch (pairsTarget)
        {
            case 2:
                ShuffleActions();
                yield return new WaitForSeconds(5);
                break;
            case 3:
                //
                break;
            case 4:
                //
                break;
        }

        shuffleCheck = false;
    }

    public int CalculateSCheck(int oldSCheck)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4 };
        list.Remove(oldSCheck);
        int index = Random.Range(0, 3);
        return list[index];
    }

    IEnumerator CoroutineSwitchChange()
    {
        speed = 480;
        if (checkSwitch == 0)
        {
            sCheck = CalculateSCheck(sCheck);
            Debug.Log("XXX" + sCheck);
            checkSwitch = 1;
        }
        yield return new WaitForSeconds(0.6f);
        if (checkSwitch == 1)
        {
            sCheck = CalculateSCheck(sCheck);
            Debug.Log("XXX" + sCheck);
            checkSwitch = 2;
        }
        yield return new WaitForSeconds(0.6f);
        if (checkSwitch == 2)
        {
            sCheck = CalculateSCheck(sCheck);
            Debug.Log("XXX" + sCheck);
            checkSwitch = 3;
        }
        yield return new WaitForSeconds(0.6f);
        if (checkSwitch == 3)
        {
            sCheck = CalculateSCheck(sCheck);
            Debug.Log("XXX" + sCheck);
            checkSwitch = 4;
        }
        yield return new WaitForSeconds(0.6f);
        if (checkSwitch == 4)
        {
            sCheck = CalculateSCheck(sCheck);
            Debug.Log("XXX" + sCheck);
            checkSwitch = 5;
        }
        yield return new WaitForSeconds(0.6f);
        if (checkSwitch == 5)
        {
            sCheck = CalculateSCheck(sCheck);
            Debug.Log("XXX" + sCheck);
            checkSwitch = 6;
        }
        yield return new WaitForSeconds(0.6f);
        if (checkSwitch == 6)
        {
            sCheck = CalculateSCheck(sCheck);
            Debug.Log("XXX" + sCheck);
            checkSwitch = 7;
        }
        yield return new WaitForSeconds(0.6f);
        if (checkSwitch == 7)
        {
            sCheck = CalculateSCheck(sCheck);
            Debug.Log("XXX" + sCheck);
            checkSwitch = 8;
        }
        yield return new WaitForSeconds(0.6f);
    }

    public void ItemsShuffle()
    {
        shuffleCheck = true;
        AdvanceButton.SetActive(false);
    }

    public void BarrelSwap()
    {
        if (pairsTarget >= 2)
        {
            Item1a.SetActive(false);
            Item1b.SetActive(false);
            Item2a.SetActive(false);
            Item2b.SetActive(false);

            Item1aBarrel.SetActive(true);
            Item1bBarrel.SetActive(true);
            Item2aBarrel.SetActive(true);
            Item2bBarrel.SetActive(true);
        }
        if (pairsTarget >= 3)
        {
            Item1c.SetActive(false);
            Item2c.SetActive(false);

            Item1cBarrel.SetActive(true);
            Item2cBarrel.SetActive(true);
        }
        if (pairsTarget >= 4)
        {
            Item3a.SetActive(false);
            Item3b.SetActive(false);
            Item3c.SetActive(false);

            Item3aBarrel.SetActive(true);
            Item3bBarrel.SetActive(true);
            Item3cBarrel.SetActive(true);
        }
        if (pair1Count == 1)
        {
            pair1Count = 0;
        }
        if (pair2Count == 1)
        {
            pair2Count = 0;
        }
        if (pair3Count == 1)
        {
            pair3Count = 0;
        }
        if (pair4Count == 1)
        {
            pair4Count = 0;
        }

        if (count == -1)
        {
            if (GameObject.Find("Barrel1a") != null)
            {
                GameObject Barrel1a = GameObject.Find("Barrel1a");
                barrel_script memoryReference1a = Barrel1a.GetComponent<barrel_script>();
                memoryReference1a.countStop = false;
            }
            Debug.Log("unlock");
            if (GameObject.Find("Barrel1b") != null)
            {
                GameObject Barrel1b = GameObject.Find("Barrel1b");
                barrel_script memoryReference1b = Barrel1b.GetComponent<barrel_script>();
                memoryReference1b.countStop = false;
            }
            if (GameObject.Find("Barrel1c") != null)
            {
                GameObject Barrel1c = GameObject.Find("Barrel1c");
                barrel_script memoryReference1c = Barrel1c.GetComponent<barrel_script>();
                memoryReference1c.countStop = false;
            }
            if (GameObject.Find("Barrel2a") != null)
            {
                GameObject Barrel2a = GameObject.Find("Barrel2a");
                barrel_script memoryReference2a = Barrel2a.GetComponent<barrel_script>();
                memoryReference2a.countStop = false;
            }
            if (GameObject.Find("Barrel2b") != null)
            {
                GameObject Barrel2b = GameObject.Find("Barrel2b");
                barrel_script memoryReference2b = Barrel2b.GetComponent<barrel_script>();
                memoryReference2b.countStop = false;
            }
            if (GameObject.Find("Barrel2c") != null)
            {
                GameObject Barrel2c = GameObject.Find("Barrel2c");
                barrel_script memoryReference2c = Barrel2c.GetComponent<barrel_script>();
                memoryReference2c.countStop = false;
            }
            if (GameObject.Find("Barrel3a") != null)
            {
                GameObject Barrel3a = GameObject.Find("Barrel3a");
                barrel_script memoryReference3a = Barrel3a.GetComponent<barrel_script>();
                memoryReference3a.countStop = false;
            }
            if (GameObject.Find("Barrel3b") != null)
            {
                GameObject Barrel3b = GameObject.Find("Barrel3b");
                barrel_script memoryReference3b = Barrel3b.GetComponent<barrel_script>();
                memoryReference3b.countStop = false;
            }
            if (GameObject.Find("Barrel3c") != null)
            {
                GameObject Barrel3c = GameObject.Find("Barrel3c");
                barrel_script memoryReference3c = Barrel3c.GetComponent<barrel_script>();
                memoryReference3c.countStop = false;
            }
        }
        count = 0; // END
    }

    public void Item1aOutOfBarrel()
    {
        if (GameObject.Find("Barrel1a") != null)
        {
            GameObject Barrel1a = GameObject.Find("Barrel1a");
            barrel_script memoryReference1a = Barrel1a.GetComponent<barrel_script>();
            if (memoryReference1a.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                Debug.Log("COUNT+1");
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference1a.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference1a.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference1a.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference1a.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item1aBarrel.SetActive(false);
        Item1a.SetActive(true);
    }
    public void Item1bOutOfBarrel()
    {
        if (GameObject.Find("Barrel1b") != null)
        {
            GameObject Barrel1b = GameObject.Find("Barrel1b");
            barrel_script memoryReference1b = Barrel1b.GetComponent<barrel_script>();
            if (memoryReference1b.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference1b.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference1b.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference1b.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference1b.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item1bBarrel.SetActive(false);
        Item1b.SetActive(true);
    }
    public void Item1cOutOfBarrel()
    {
        if (GameObject.Find("Barrel1c") != null)
        {
            GameObject Barrel1c = GameObject.Find("Barrel1c");
            barrel_script memoryReference1c = Barrel1c.GetComponent<barrel_script>();
            if (memoryReference1c.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference1c.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference1c.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference1c.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference1c.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item1cBarrel.SetActive(false);
        Item1c.SetActive(true);
    }
    public void Item2aOutOfBarrel()
    {
        if (GameObject.Find("Barrel2a") != null)
        {
            GameObject Barrel2a = GameObject.Find("Barrel2a");
            barrel_script memoryReference2a = Barrel2a.GetComponent<barrel_script>();
            if (memoryReference2a.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference2a.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference2a.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference2a.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference2a.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item2aBarrel.SetActive(false);
        Item2a.SetActive(true);
    }
    public void Item2bOutOfBarrel()
    {
        if (GameObject.Find("Barrel2b") != null)
        {
            GameObject Barrel2b = GameObject.Find("Barrel2b");
            barrel_script memoryReference2b = Barrel2b.GetComponent<barrel_script>();
            if (memoryReference2b.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference2b.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference2b.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference2b.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference2b.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item2bBarrel.SetActive(false);
        Item2b.SetActive(true);
    }
    public void Item2cOutOfBarrel()
    {
        if (GameObject.Find("Barrel2c") != null)
        {
            GameObject Barrel2c = GameObject.Find("Barrel2c");
            barrel_script memoryReference2c = Barrel2c.GetComponent<barrel_script>();
            if (memoryReference2c.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference2c.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference2c.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference2c.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference2c.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item2cBarrel.SetActive(false);
        Item2c.SetActive(true);
    }
    public void Item3aOutOfBarrel()
    {
        if (GameObject.Find("Barrel3a") != null)
        {
            GameObject Barrel3a = GameObject.Find("Barrel3a");
            barrel_script memoryReference3a = Barrel3a.GetComponent<barrel_script>();
            if (memoryReference3a.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference3a.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference3a.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference3a.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference3a.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item3aBarrel.SetActive(false);
        Item3a.SetActive(true);
    }
    public void Item3bOutOfBarrel()
    {
        if (GameObject.Find("Barrel3b") != null)
        {
            GameObject Barrel3b = GameObject.Find("Barrel3b");
            barrel_script memoryReference3b = Barrel3b.GetComponent<barrel_script>();
            if (memoryReference3b.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference3b.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference3b.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference3b.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference3b.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item3bBarrel.SetActive(false);
        Item3b.SetActive(true);
    }
    public void Item3cOutOfBarrel()
    {
        if (GameObject.Find("Barrel3c") != null)
        {
            GameObject Barrel3c = GameObject.Find("Barrel3c");
            barrel_script memoryReference3c = Barrel3c.GetComponent<barrel_script>();
            if (memoryReference3c.itemType == 0)
            {
                if (preventCountLimit == false)
                {
                    count += 2;
                }
                if (preventCountLimit == true)
                {
                    count += 1;
                    preventCountLimit = false;
                }
            }
            else
            {
                count += 1;
                if (count == 1)
                {
                    preventCountLimit = true;
                }
                else
                {
                    preventCountLimit = false;
                }
            }

            if (memoryReference3c.itemType == 1)
            {
                pair1Count += 1;
            }
            if (memoryReference3c.itemType == 2)
            {
                pair2Count += 1;
            }
            if (memoryReference3c.itemType == 3)
            {
                pair3Count += 1;
            }
            if (memoryReference3c.itemType == 4)
            {
                pair4Count += 1;
            }
        }
        Item3cBarrel.SetActive(false);
        Item3c.SetActive(true);
    }

    public void Update()
    {
        if (count == 2)
        {
            StartCoroutine(CoroutineWait());
        }

        if ((pair1CountEnd == false) && (pair1Count == 2))
        {
            pair1Count = -1;
            pairsMade += 1;
         //   pair1CountEnd = true;
        }
        if ((pair2CountEnd == false) && (pair2Count == 2))
        {
            pair2Count = -1;
            pairsMade += 1;
            //   pair2CountEnd = true;
        }
        if ((pair3CountEnd == false) && (pair3Count == 2))
        {
            pair3Count = -1;
            pairsMade += 1;
            //   pair3CountEnd = true;
        }
        if ((pair4CountEnd == false) && (pair4Count == 2))
        {
            pair4Count = -1;
            pairsMade += 1;
            //   pair4CountEnd = true;
        }

        //   if ((pair1CountEnd == true) && (pair2CountEnd == true) && (pair3CountEnd == true) && (pair4CountEnd == true) && endCheck == false)
        if ((pairsMade == pairsTarget) && endCheck == false)
        {
            endCheck = true;
            StartCoroutine(CoroutineEndWait());
        }

        step = speed * Time.deltaTime;

        if (shuffleCheck == true)
        {
            StartCoroutine(CoroutineShuffle());

            if (pairsTarget == 2)
            {
                StartCoroutine(CoroutineSwitchChange());
            }
            if (pairsTarget == 3)
            {
                ///
            }
            if (pairsTarget == 4)
            {
                ///
            }
        }


    }

    public void ShuffleActions()
    {
        if (pairsTarget == 2)
        {
            if (sCheck == 1)
            {
                X1a.transform.position = Vector3.MoveTowards(X1a.transform.position, Item2bPos, step);
                X1b.transform.position = Vector3.MoveTowards(X1b.transform.position, Item1aPos, step);
                X2a.transform.position = Vector3.MoveTowards(X2a.transform.position, Item1bPos, step);
                X2b.transform.position = Vector3.MoveTowards(X2b.transform.position, Item2aPos, step);
            }
            if (sCheck == 2)
            {
                X1a.transform.position = Vector3.MoveTowards(X1a.transform.position, Item2aPos, step);
                X1b.transform.position = Vector3.MoveTowards(X1b.transform.position, Item2bPos, step);
                X2a.transform.position = Vector3.MoveTowards(X2a.transform.position, Item1aPos, step);
                X2b.transform.position = Vector3.MoveTowards(X2b.transform.position, Item1bPos, step);
            }
            if (sCheck == 3)
            {
                X1a.transform.position = Vector3.MoveTowards(X1a.transform.position, Item1bPos, step);
                X1b.transform.position = Vector3.MoveTowards(X1b.transform.position, Item2aPos, step);
                X2a.transform.position = Vector3.MoveTowards(X2a.transform.position, Item2bPos, step);
                X2b.transform.position = Vector3.MoveTowards(X2b.transform.position, Item1aPos, step);
            }
        }
        if (pairsTarget == 3)
        {
            ///
        }
        if (pairsTarget == 4)
        {
            ///
        }
    }
}
