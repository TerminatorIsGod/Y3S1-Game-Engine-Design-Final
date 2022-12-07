using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actions
{
    public abstract void ExecuteAction(Camera cam);
}

public class Nothing : Actions
{
    public override void ExecuteAction(Camera cam)
    {
        return;
    }
}
public class MoveCameraUp : Actions
{
    public override void ExecuteAction(Camera cam)
    {
        //move camera

        if(cam.transform.rotation.x < 45)
            cam.transform.Rotate(new Vector3(-30 * Time.deltaTime, 0, 0));
    }
}

public class MoveCameraDown : Actions
{
    public override void ExecuteAction(Camera cam)
    {
        //move camera
        if (cam.transform.rotation.x > -45)
            cam.transform.Rotate(new Vector3(30 * Time.deltaTime, 0, 0));
    }
}

public class MoveCameraLeft : Actions
{
    public override void ExecuteAction(Camera cam)
    {
        //move camera
        Transform trans = cam.gameObject.GetComponentInParent<Transform>();
        if (trans.rotation.y > -45)
            trans.Rotate(new Vector3(0, -30 * Time.deltaTime, 0));
    }
}

public class MoveCameraRight : Actions
{
    public override void ExecuteAction(Camera cam)
    {
        //move camera
        Transform trans = cam.gameObject.GetComponentInParent<Transform>();
        if (trans.rotation.y < 45)
            trans.Rotate(new Vector3(0, 30 * Time.deltaTime, 0));
    }
}

public class Shoot : Actions
{
    public override void ExecuteAction(Camera cam)
    {
        
    }
}