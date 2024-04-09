using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private List<int> spawnInterval;
    private int rndBall;
    private float rndInterval;

    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, RandomInterval());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        rndBall = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[rndBall], spawnPos, ballPrefabs[rndBall].transform.rotation);
    }

    float RandomInterval()
    {
        float rndInterval = Random.Range(3, 5);
        Debug.Log(rndInterval);
        return rndInterval;
    }

}
