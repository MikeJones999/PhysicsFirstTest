using UnityEngine;

public class AddForce : MonoBehaviour {

    void OnMouseDown()
    {

        GetComponent<Rigidbody>().AddForce(-transform.forward * 5000, ForceMode.Acceleration);
        GetComponent<Rigidbody>().useGravity = true;
    }

}
