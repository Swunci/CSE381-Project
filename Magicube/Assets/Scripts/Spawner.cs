using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnees;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public Vector3 axis;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    
    public void SpawnObject()
    {
        int randomNumber = Random.Range(0, 10000) % 3;
        int randomNumber2 = Random.Range(0, 10000) % 4;
        Debug.Log(randomNumber);
        Debug.Log(randomNumber2);
        //spawnees[randomNumber].transform.Rotate(0, 0, randomNumber2 * 90f, Space.Self);
        spawnees[randomNumber].transform.Rotate(axis, 90f, Space.World);
        Instantiate(spawnees[randomNumber], transform.position, transform.rotation).transform.Rotate(axis, 90f);
 
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
