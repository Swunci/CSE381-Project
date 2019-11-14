using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZWallController : MonoBehaviour
{
    public float speed;
    public GameObject target;
    private Vector3 direction;
    private void Start()
    {
        direction = Vector3.Normalize(target.transform.position - transform.position);
    }
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Destroyer" || collider.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
