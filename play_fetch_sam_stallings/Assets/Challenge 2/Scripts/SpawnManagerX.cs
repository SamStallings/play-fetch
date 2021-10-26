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

    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartSpawnRandomBallDelay", startDelay);
    }

    void StartSpawnRandomBallDelay()
    {
        StartCoroutine(SpawnRandomBall());
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall()
    {
        while (true)
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            // instantiate ball at random spawn location
            int selectedBall = Random.Range(0, ballPrefabs.Length);
            Instantiate(ballPrefabs[selectedBall], spawnPos, ballPrefabs[selectedBall].transform.rotation);
            yield return new WaitForSeconds(Random.Range(2, 6));
        }

    }
}