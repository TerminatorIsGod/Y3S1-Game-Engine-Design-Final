using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDucks : MonoBehaviour
{
    ObjectPooler objPooler;//ObjectPooler._instance;

    // Start is called before the first frame update
    void Start()
    {
        objPooler = FindObjectOfType<ObjectPooler>();
        spawnDuck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnDuck()
    {
        GameObject bird = objPooler.requestBird();
        bird.transform.position = new Vector3(-10, Random.Range(0, 10), 0);
        bird.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(1,10), Random.Range(-3,3), 0), ForceMode.Impulse);

        Invoke("spawnDuck", Random.Range(1, 5));
    }
}
