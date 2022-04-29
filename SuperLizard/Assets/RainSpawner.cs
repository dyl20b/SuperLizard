using System.Collections;
using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    public float destroyTime = 3f;

    public float spawnDelay = .3f;

    public GameObject rain;

    public Transform[] spawnPoints;

    public float nextTimeToSpawn;
    private int check, randomIndex;

    void Start()
    {

        nextTimeToSpawn = Random.Range(0f, 3f);
    }

    void FixedUpdate()
    {
        nextTimeToSpawn -= Time.deltaTime;
        randomIndex = Random.Range(0, spawnPoints.Length);
        if (nextTimeToSpawn <= 0.0f && check != randomIndex)
        {

            Transform spawnPoint = spawnPoints[randomIndex];

            GameObject rainClone = Instantiate(rain, spawnPoint.position, spawnPoint.rotation);
            nextTimeToSpawn = Random.Range(0f, 3f);

            check = randomIndex;
            Destroy(rainClone, destroyTime);
        }
    }
}