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
        for (int i = 0; i <= 5; i++)
        {
            randomIndex = Random.Range(0, spawnPoints.Length);
            if (randomIndex < spawnPoints.Length)
            {
                Transform spawnPoint = spawnPoints[randomIndex];
                GameObject bugClone = Instantiate(bug, spawnPoint.position, spawnPoint.rotation);
                nextTimeToSpawn = Random.Range(0f, 1f);
            }
        }
    }

}