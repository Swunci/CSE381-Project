using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFetcher : MonoBehaviour
{
    public GameObject spawner;
    public GameObject parent;
    private Spawner spawner_script;
    private int index = 0;
    private int next = 0;
    private GameObject currentFace;

    private void Start()
    {
        spawner_script = spawner.GetComponent<Spawner>();
    }
    void Update()
    {
        if (index == next && index <= spawner_script.spawnNumber)
        {
            if (index != 0 && index != spawner_script.spawnNumber)
            {

                currentFace.transform.Rotate(0, 0, -spawner_script.getRotationNumbers()[index - 1] * 90f);
            }
            if (index == spawner_script.spawnNumber)
            {
                DestroyImmediate(currentFace);
                index = 0;
            }
            else
            {
                DestroyImmediate(currentFace);
                currentFace = Instantiate(spawner_script.spawnees[spawner_script.getFaceNumbers()[index]], transform);
                currentFace.transform.Rotate(0, 0, spawner_script.getRotationNumbers()[index] * 90f);
                currentFace.transform.localScale = new Vector3(7, 7, 7);


                Component[] scripts = currentFace.GetComponentsInChildren<ZWallController>();
                foreach (ZWallController script in scripts)
                {
                    script.enabled = false;
                }

                Component[] colliders = currentFace.GetComponentsInChildren<SphereCollider>();
                foreach (SphereCollider collider in colliders)
                {
                    collider.enabled = false;
                }

                Component[] rigidbodies = currentFace.GetComponentsInChildren<Rigidbody>();
                foreach (Rigidbody rb in rigidbodies)
                {
                    Destroy(currentFace.GetComponent<Rigidbody>());
                }
                next++;
            }
        }

    }

    public void IncrementIndex()
    {
        index++;
    }
}
