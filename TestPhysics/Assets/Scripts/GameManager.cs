﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(this);
        }

    }


    // Use this for initialization
    void Start () {


        ProjectileManager.instance.StartGame();
        BuildingManager.instance.StartBuilding();


	}
	
	// Update is called once per frame
	void Update () {
		
	}


     
}
