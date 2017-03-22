using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Camera mainCam;
    public int offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

//        var ball = GetComponent<GameObject>();
        Vector3 ballPos = this.transform.position;
        mainCam.transform.position = new Vector3(ballPos.x + offset, ballPos.y + 5, ballPos.z + offset);
	}
}
