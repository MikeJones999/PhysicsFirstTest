using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerLob : MonoBehaviour {

    public float sensitivity;
    private Vector3 mouseReference;
    private Vector3 mouseOffset;

    private bool isMouseDown;
    float rotateX;


    // Use this for initialization
    void Start()
    {
        isMouseDown = false;



    }

    // Update is called once per frame
    void Update()
    {


        if (isMouseDown)
        {
          
            rotateX += Input.GetAxis("Mouse Y") * sensitivity;
            //rotation.y += Input.GetAxis("Mouse X") * sensitivity;

            //Used to set the ball forward on first click
            //if (rotateX == 0.0f)
            //{
            //    rotateX = 180.0f;
            //}
            rotateX = Mathf.Clamp(rotateX,  0.0f, 90.0f);
            transform.localEulerAngles = new Vector3(rotateX, transform.localEulerAngles.y, transform.localEulerAngles.z);
        }
    }



    void OnMouseDown()
    {
        isMouseDown = true;

      
    }

    void OnMouseUp()
    {
        isMouseDown = false;
    }


}
