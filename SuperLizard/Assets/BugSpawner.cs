using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class BugSpawner : MonoBehaviour
{
    public float destroyTime = 5f;
    public GameObject bug;
    public GameObject[] bugs; // for object reference. without I was getting a bug
    public Transform[] spawnPoints;
    public List<Transform> possibleSpawns = new List<Transform>();

    void Start()
    {
        // loop to fill the possible spawn points
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            possibleSpawns.Add(spawnPoints[i]);
        }

        InvokeRepeating("SpawnBug", 0f, 5f);
    }

    void SpawnBug()
    {
        if (possibleSpawns.Count > 0)
        {
            int randomIndex = Random.Range(0, possibleSpawns.Count);
            int spawnObject = Random.Range(0, bugs.Length);  // for object reference
            Transform spawnPoint = spawnPoints[randomIndex];

            // create as a game object to allow deletion
            GameObject bugClone = Instantiate(bugs[spawnObject], possibleSpawns[randomIndex].position, possibleSpawns[randomIndex].rotation) as GameObject;
            bugClone.GetComponent<Destroy>().mySpawnPoint = possibleSpawns[randomIndex];

            possibleSpawns.RemoveAt(randomIndex);
        }
    }
}