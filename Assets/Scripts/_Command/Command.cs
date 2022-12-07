using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{

    Actions WKey = new MoveCameraUp();
    Actions SKey = new MoveCameraDown();
    Actions AKey = new MoveCameraLeft();
    Actions DKey = new MoveCameraRight();
    //Actions SpaceKey = new Shoot();

    Camera pCam;

    bool wasLastShootMiss = false;

    // Start is called before the first frame update
    void Start()
    {
        pCam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            WKey.ExecuteAction(pCam);

        if (Input.GetKey(KeyCode.S))
            SKey.ExecuteAction(pCam);

        if (Input.GetKey(KeyCode.A))
            AKey.ExecuteAction(pCam);

        if (Input.GetKey(KeyCode.D))
            DKey.ExecuteAction(pCam);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Camera playerCam = FindObjectOfType<Camera>();

            Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
            RaycastHit hit; //, 100f, 6, 
            Debug.DrawLine(playerCam.transform.position, playerCam.transform.forward * 200f, Color.red, 5f);
            if (Physics.Raycast(ray, out hit, 200f))
            {   
                if (hit.rigidbody.gameObject.GetComponent<Bird>())
                {
                    Debug.Log("Hit bird");
                    //hit bird
                    wasLastShootMiss = false;
                    hit.rigidbody.gameObject.GetComponent<Bird>().ShotDown();
                }
                
            }
            else
            {
                if (wasLastShootMiss)
                {
                    Actions tempWKey = WKey;
                    Actions tempSKey = SKey;
                    WKey = tempSKey;
                    SKey = tempWKey;
                    wasLastShootMiss = false;
                } else
                {
                    wasLastShootMiss = true;
                }
        
            }
        }
    }
}
