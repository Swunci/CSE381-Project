using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private int hit = 0;
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }

        // Player rotation

        // Rotate clockwise on x-axis of the world
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(90, 0, 0, Space.World);
        }
        // Rotate clockwise on y-axis of the world
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(0, 90, 0, Space.World);
        }
        // Rotate clockwise on z-axis of the world
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0, 0, -90, Space.World);
        }
    }

    public int getHit()
    {
        return hit;
    }
    public void setHit(int hit)
    {
        this.hit = hit;
    }
}