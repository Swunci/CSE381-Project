using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {

        /*
        int randomAngleX = Random.Range(-45, 45);
        int randomAngleY = Random.Range(-45, 45);
        int randomAngleZ = Random.Range(-45, 45);
        transform.Rotate(new Vector3(randomAngleX, randomAngleY, randomAngleZ) * Time.deltaTime);
        */
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime * speed, Space.World);
    }
}

