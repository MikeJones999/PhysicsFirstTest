using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour {



    public static ProjectileManager instance;

    public GameObject ProjectilePrefab;
    public GameObject SpawnProjectile;
    public GameObject ProjectileLob;
    public GameObject SpawnProjectileLob;
    private GameObject projectile;
    private GameObject projectileLob;

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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        projectile = Instantiate(ProjectilePrefab, SpawnProjectile.transform.position, Quaternion.identity);
        projectile.transform.Rotate(new Vector3(0, 90, 0));

        projectileLob = Instantiate(ProjectileLob, SpawnProjectileLob.transform.position, Quaternion.identity);
        projectileLob.transform.Rotate(new Vector3(0, 90, 0));
        //need to attach ball to arm
    }

    public GameObject GetProjectile()
    {
        return projectile;
    }

    public GameObject GetProjectileLob()
    {
        return projectileLob;
    }

}
