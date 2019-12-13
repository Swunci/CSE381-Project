
 
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class Wind : MonoBehaviour
{
    public List<GameObject> AffectedObjects;
    private Vector3 direction = new Vector3(0, 0, -1);
    private int speed = 0;
    private float timer = 0;

    void OnTriggerEnter(Collider collidee)
    {
          AffectedObjects.Add(collidee.gameObject);
    }
 
    void OnTriggerExit(Collider collidee)
    {
       AffectedObjects.Remove(collidee.gameObject);
    }
 
    void FixedUpdate()
    {
       for(int I =0; I < AffectedObjects.Count; I++)
       {
            Debug.Log("FAST");
           AffectedObjects[I].GetComponent<Rigidbody>().AddForce(direction * speed);
       }
        timer += Time.deltaTime;
        if (timer > 60)
        {
            speed = 100;
        }
        if(timer > 120)
        {
            speed = 500;
        }
        if (timer > 3)
        {
            speed = 1000;
        }
    }
}
 