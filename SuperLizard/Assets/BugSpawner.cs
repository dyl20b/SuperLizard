using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class BugSpawner : MonoBehaviour
{
    public float destroyTime = 10f;
    public float spawnDelay = 10f;
    public GameObject bug;
    public Transform[] spawnPoints;
    public float nextTimeToSpawn;
    private int check, randomIndex;

    void Start()
    {
        nextTimeToSpawn = Random.Range(0f, 1f);
    }

    void FixedUpdate()
    {
        nextTimeToSpawn -= Time.deltaTime;
        randomIndex = Random.Range(0, spawnPoints.Length);
        if (nextTimeToSpawn <= 0.0f && check != randomIndex)
        {

            Transform spawnPoint = spawnPoints[randomIndex];

            GameObject bugClone = Instantiate(bug, spawnPoint.position, spawnPoint.rotation);
            nextTimeToSpawn = Random.Range(0f, 1f);

            check = randomIndex;
            Destroy(bugClone, destroyTime);
        }
    }
}