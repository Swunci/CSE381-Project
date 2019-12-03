using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFormRotator : MonoBehaviour
{
    public float speed;
    public int randomAngleX;
    public int randomAngleY;
    public int randomAngleZ;
    // Update is called once per frame
    void Update()
    { 
        transform.Rotate(new Vector3(randomAngleX, randomAngleY, randomAngleZ) * Time.deltaTime);
    }
}
