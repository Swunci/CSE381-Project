using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject deadPlayer;
    public GameObject player;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    public GameObject camera;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    private PlayerController player_script;
    private CameraController camera_script;
    private GameObject clone;

    void OnCollisionEnter(Collision collision)
    {
        player_script = player.GetComponent<PlayerController>();
        camera_script = camera.GetComponent<CameraController>();
        //if (player_script.getHit() == 0)
        //{
            clone = Instantiate(deadPlayer, player.transform.position, player.transform.rotation);
            camera_script.target = clone.transform;
            Destroy(this.gameObject.transform.root.gameObject);
            //player_script.setHit(1);

        //}
    }

    public void setValues(GameObject deadPlayer, GameObject player, GameObject camera)
    {
        this.deadPlayer = deadPlayer;
        this.player = player;
        this.camera = camera;
    }
}
