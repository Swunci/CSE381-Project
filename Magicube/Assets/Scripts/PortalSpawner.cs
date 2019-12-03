using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner : MonoBehaviour
{
    public float time;
    public GameObject portal;
    public GameObject spawner;
    private Spawner spawner_script;
    private PortalController portal_controller_script;
    private bool spawned = false;

    private void Start()
    {
        spawner_script = spawner.GetComponent<Spawner>();
        portal_controller_script = portal.GetComponent<PortalController>();
    }
    void Update()
    {
        if (spawner_script.stopSpawning && !spawned)
        {
            if (time > 0.0f)
            {
                time -= Time.deltaTime;
            }
            else
            {
                portal_controller_script.moving = true;
                spawned = true;
            }

        }
    }
}
