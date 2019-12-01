using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Random.rotation;
    }
}
