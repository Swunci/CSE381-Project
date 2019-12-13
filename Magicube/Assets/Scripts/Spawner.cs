using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnees;
    public float spawnTime;
    public float spawnDelay;
    private int randomFace;
    private int randomRotation;
    private GameObject face;
    private List<int> faceNumbers = new List<int>();
    private List<int> rotationNumbers = new List<int>();
    public int spawnNumber;
    private int counter = 0;
    public bool stopSpawning = false;
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
        spawnees[randomFace].transform.Rotate(0, 0, randomRotation * 90f, Space.World);
        face = Instantiate(spawnees[randomFace], transform.position, spawnees[randomFace].transform.rotation);
        spawnees[randomFace].transform.Rotate(0, 0, -randomRotation * 90f, Space.World);
        faceNumbers.Add(randomFace);
        rotationNumbers.Add(randomRotation);
        counter++;

        if (counter == spawnNumber)
        {
            stopSpawning = true;
            CancelInvoke("SpawnObject");
        }
    }

    public List<int> getFaceNumbers()
    {
        return faceNumbers;
    }

    public List<int> getRotationNumbers()
    {
        return rotationNumbers;
    }
}
