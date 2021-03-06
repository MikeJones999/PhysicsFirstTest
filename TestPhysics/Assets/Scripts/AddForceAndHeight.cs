﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceAndHeight : MonoBehaviour {

    private GameObject ball;
    // public GameObject pointer;

    public int forceApllied;
    public bool fired;


    public GameObject Catapult;

    private void Start()
    {
        fired = false;
    }
    /// <summary>
    /// 
    /// </summary>
    void OnMouseDown()
    {
        if (!fired)
        {
            ball = ProjectileManager.instance.GetProjectileLob();

            ball.GetComponent<Rigidbody>().AddForce(-ball.transform.forward * forceApllied, ForceMode.Acceleration);
            ball.GetComponent<Rigidbody>().useGravity = true;
            Component[] components = ball.GetComponentsInChildren<Component>(true);

            var temp = ball.transform.GetChild(0);
            //temp.gameObject
            Destroy(temp.gameObject);
            fired = true;


            //catapult
            Catapult.GetComponent<Animator>().Play("FireShot");

        }
    }
}
