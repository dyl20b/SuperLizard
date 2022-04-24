using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float destroyTime = 3f;

    public float spawnDelay = .3f;

    public GameObject car;

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

            GameObject carClone = Instantiate(car, spawnPoint.position, spawnPoint.rotation);
            nextTimeToSpawn = Random.Range(0f, 1f);

            check = randomIndex;
            Destroy(carClone, destroyTime);
        }
    }
}

   
  
