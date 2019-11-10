using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraOrbit;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        cameraOrbit.position = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
        transform.LookAt(target.position);
    }
}
