using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePreFab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePreFab, spawnPos, obstaclePreFab.transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
