//lets add some target
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Score scoreManager;
    public Target mainTarget;

    //this method is called whenever a collision is detected
    private void OnCollisionEnter(Collision collision)
    {
        //on collision adding point to the score
        scoreManager.AddPoint();

        //System.Debug.Log("Collision Detected");
        //after collision is detected destroy the gameobject
        Destroy(gameObject);
    }
}