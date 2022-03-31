using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float destroyTime = 5f;
    private BugSpawner bugspawnscript;
    public Transform mySpawnPoint;

    void Start()
    {
        bugspawnscript = GameObject.Find("BugSpawner").GetComponent<BugSpawner>();
        StartCoroutine("DestroyIt");
    }

    IEnumerator DestroyIt()
    {
        yield return new WaitForSeconds(destroyTime);
        for(int i = 0; i<bugspawnscript.spawnPoints.Length; i++)
        {
            if(bugspawnscript.spawnPoints[i] == mySpawnPoint)
            {
                bugspawnscript.possibleSpawns.Add(bugspawnscript.spawnPoints[i]);
            }
        }
        Destroy(gameObject);
    }
}
