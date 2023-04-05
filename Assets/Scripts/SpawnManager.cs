using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    public float StartDelay = 2;
    public float RepeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", StartDelay, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnObstacle()
    {
        Instantiate(ObstaclePrefab,transform.position, ObstaclePrefab.transform.rotation);
    }
   
}
