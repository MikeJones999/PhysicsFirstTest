using UnityEngine;

public class AddForce : MonoBehaviour {


    private GameObject ball;
   // public GameObject pointer;

    public int forceApllied;


    public GameObject Catapult;
    void OnMouseDown()
    {

        ball = ProjectileManager.instance.GetProjectile();

        ball.GetComponent<Rigidbody>().AddForce(-ball.transform.forward * forceApllied, ForceMode.Acceleration);
        ball.GetComponent<Rigidbody>().useGravity = true;
        Component[] components = ball.GetComponentsInChildren<Component>(true);

        var temp = ball.transform.GetChild(0);
        //temp.gameObject
        Destroy(temp.gameObject);



        //catapult
        Catapult.GetComponent<Animator>().Play("FireShot");
    }

}
