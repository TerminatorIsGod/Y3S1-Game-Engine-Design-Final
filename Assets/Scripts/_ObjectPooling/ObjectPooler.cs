using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public GameObject birdPrefab;
    public int poolSize = 20;
    public List<GameObject> birdPool = new List<GameObject>();

    //int counter = 0;

    public static ObjectPooler _instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        } else
        {
            Destroy(this);
        }

        for (int i = 0; i < poolSize; i++)
        {
            GameObject tempBird = Instantiate(birdPrefab);
            tempBird.SetActive(false);
            birdPool.Add(tempBird);
        }
    }

    public GameObject requestBird()
    {
        for(int i = 0; i < birdPool.Count; i++)
        {
            if (!birdPool[i].activeSelf)
            {
                birdPool[i].SetActive(true);
                return birdPool[i];
            }
        }

        GameObject tempBird = Instantiate(birdPrefab);
        tempBird.SetActive(true);
        birdPool.Add(tempBird);

        return tempBird;

        /*if (!birdPool[counter].activeSelf)
        {
            GameObject birdToReturn = birdPool[counter];
            counter++;

            if(counter > birdPool.Count)
            {
                counter = 0;
            }

            return birdToReturn;
        } else
        {
            
        } */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
