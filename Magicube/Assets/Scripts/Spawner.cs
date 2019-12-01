using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnees;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    private int randomFace;
    private int randomRotation;
  

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    
    void Update()
    {
        randomFace = Random.Range(0, spawnees.Length);
        randomRotation = Random.Range(0, 4);
    }
    public void SpawnObject()
    {
        Debug.Log("Random Face: " + randomFace);
        Debug.Log("Rotation Number: " + randomRotation * 90f);
        GameObject face = spawnees[randomFace];
        face.transform.Rotate(0, 0, randomRotation * 90f, Space.World);
  
        Instantiate(face, transform.position, face.transform.rotation);
 
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
