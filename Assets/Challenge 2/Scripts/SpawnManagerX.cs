using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    [SerializeField] GameObject[] ballPrefabs = new GameObject[3];

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private float leastDelay = 3;
    private float maxDelay = 5;
    private float timeCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    void Update()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        if (timeCount < Random.Range(leastDelay, maxDelay))
        {
            timeCount+=Time.deltaTime;
        }
        else
        {
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[Random.Range(0, 3)], spawnPos, ballPrefabs[Random.Range(0, 3)].transform.rotation);
            timeCount = 0;
        }
    }
    

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
       
    }

}
