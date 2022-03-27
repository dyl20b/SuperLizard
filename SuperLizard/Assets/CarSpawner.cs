using System.Collections;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float destroyTime = 3f;

    public GameObject car;

    public Transform[] spawnPoints;

    void Start()
    {
        InvokeRepeating("SpawnCar", 0f, 1.5f);
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        GameObject carClone = Instantiate(car, spawnPoint.position, spawnPoint.rotation) as GameObject;
        Destroy(carClone, destroyTime);
    }
}
