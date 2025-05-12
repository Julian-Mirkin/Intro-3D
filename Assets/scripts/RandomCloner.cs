using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloner : MonoBehaviour
{
    public int randomNumber;
    public int min = 1;
    public int max = 3;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;


    // Start is called before the first frame update
    void Start()
    {
        CloneRandom();
    }

    public void CloneRandom()
    {
        randomNumber = Random.Range(min, max + 1);
        GameObject clone;
        if (randomNumber == 0)
        {
            clone = prefab1;
        }
        else if (randomNumber == 1)
        {
            clone = prefab2;
        }
        else if (randomNumber == 2)
        {
            clone = prefab3;
        }
        else
        {
            clone = prefab1;
        }
        Instantiate(clone);
    }

}
