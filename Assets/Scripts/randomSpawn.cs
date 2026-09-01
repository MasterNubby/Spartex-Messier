using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawn : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public float spawnTime = 5.0f;

    void Start()
    {

        InvokeRepeating("createObstacle", spawnTime, spawnTime);

    }

    void Update()
    {
        
    }



    void createObstacle()
    {

        Instantiate(obstaclePrefab, new Vector3(Random.Range(-14.0f, 14.0f), Random.Range(-14.0f, 14.0f), -3.3f), Quaternion.identity);
        Debug.Log("Made an object");

    }

}
