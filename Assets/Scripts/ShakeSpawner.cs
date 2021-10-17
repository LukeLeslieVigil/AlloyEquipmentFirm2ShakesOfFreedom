using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeSpawner : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject shake;
    
    private GameObject shakeClone;
    private int spawnPoint;
    private int currentSpawnPoint = -1;

    private void Start()
    {
        spawnPoint = Random.Range(0, spawnLocations.Length);
        shake.transform.position = spawnLocations[spawnPoint].position;
    }
    public void MoveShake()
    {
        // Checks if the shake exists, then moves to a random spawn position
        if (shake != null)
        {
            spawnPoint = Random.Range(0, spawnLocations.Length);
            if (spawnPoint != currentSpawnPoint)
            {
                shake.transform.position = spawnLocations[spawnPoint].position;
                currentSpawnPoint = spawnPoint;
            }
            //Debug.Log("Shake spawned at Spawn Location: " + spawnPoint);
        }
    }
}
