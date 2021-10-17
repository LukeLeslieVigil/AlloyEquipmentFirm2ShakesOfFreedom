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


    void spawnShake(int num)
    {
        // Sets an instantiatable gameobject of a shake,
        // and takes in input of which spawn location it will spawn at.
        shakeClone = Instantiate(shake, spawnLocations[num].transform);
    }

    private void Update()
    {
        // Checks if the instantiatable shake exists, then creates one in a random spawn position
        /*if (shakeClone == null)
        {
            spawnPoint = Random.Range(0, spawnLocations.Length);
            if (spawnPoint != currentSpawnPoint)
            {
                spawnShake(spawnPoint);
                currentSpawnPoint = spawnPoint;
            }
            //Debug.Log("Shake spawned at Spawn Location: " + spawnPoint);
        }*/
    }
}
