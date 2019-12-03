using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomingUIUpdater : MonoBehaviour
{
    public GameObject obstacleUI;
    private ObstacleFetcher script;

    private void Start()
    {
        script = obstacleUI.GetComponent<ObstacleFetcher>();
    }

    private void OnTriggerEnter(Collider other)
    { 
        script.IncrementIndex();
    }
}
