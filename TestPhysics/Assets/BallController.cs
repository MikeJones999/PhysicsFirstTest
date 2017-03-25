using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float sensitivity;
    private Vector3 mouseReference;
    private Vector3 mouseOffset ;
    
    private bool isMouseDown;
    float rotateY;


    // Use this for initialization
    void Start () {
        isMouseDown = false;
       
        

    }
	
	// Update is called once per frame
	void Update () {


        if (isMouseDown)
        {
            //mouseOffset = (Input.mousePosition - mouseReference);

            //rotation.y = (mouseOffset.x) * sensitivity;
            ////rotation.y = Mathf.Clamp((mouseOffset.x), -45, -130) * sensitivity;

            //rotation.y = Mathf.Clamp(rotation.y, -45.0f, 130.0f);


            //// transform.Rotate(rotation);
            //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, -rotation.y, transform.localEulerAngles.z);

            //mouseReference = Input.mousePosition;
            rotateY += Input.GetAxis("Mouse X") * sensitivity;
            //rotation.y += Input.GetAxis("Mouse X") * sensitivity;

            //Used to set the ball forward on first click
            if (rotateY == 0.0f)
            {
                rotateY = 90;
            }
            rotateY = Mathf.Clamp(rotateY, 45.0f, 130.0f);
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, rotateY, transform.localEulerAngles.z);
        }
	}



    void OnMouseDown()
    {
        isMouseDown = true;

        //store mouse position
        //mouseReference = Input.mousePosition;
    } 

    void OnMouseUp()
    {
        isMouseDown = false;
    }

    
}
