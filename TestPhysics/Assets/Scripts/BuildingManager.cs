using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour {

    // Use this for initialization
    public static BuildingManager instance;
    public GameObject firstBlock;
    public GameObject block;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartBuilding()
    {
        Vector3 pos = firstBlock.transform.position;
        Vector3 lastBlock = pos;
        Vector3 firstBlockRow = pos;
        for (int i = 0; i < 3; i++)
        {
            if(i != 0)
            {
                lastBlock = new Vector3(firstBlockRow.x, firstBlockRow.y + 1.1f, firstBlockRow.z);
            }
            for(int j = 0; j< 3; j++)
            {
                var newBlock = new Vector3(lastBlock.x, lastBlock.y, lastBlock.z + -1.1f);
                if (j == 0)
                {
                    firstBlockRow = new Vector3(lastBlock.x, lastBlock.y, lastBlock.z + -0.6f);
                }
                lastBlock = newBlock;
                Instantiate(block, newBlock, Quaternion.identity);
            }

        }
    }
}
