﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime, Space.World);
    }
}
