using UnityEngine;

public class AddForce : MonoBehaviour {


    public GameObject ball;
    public int forceApllied;
    void OnMouseDown()
    {

        ball.GetComponent<Rigidbody>().AddForce(-ball.transform.forward * forceApllied, ForceMode.Acceleration);
        ball.GetComponent<Rigidbody>().useGravity = true;
    }

}
