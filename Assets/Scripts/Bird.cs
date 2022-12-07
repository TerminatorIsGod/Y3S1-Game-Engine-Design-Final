using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShotDown()
    {
        FindObjectOfType<ScoreManager>().IncreaseScore(1);
        this.gameObject.SetActive(false);
    }
}
