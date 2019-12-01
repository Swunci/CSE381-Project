using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerRotator : MonoBehaviour
{
    private float delay;
    private bool pressed = false;


    void Update()
    {

        Reset();
        
        if (!pressed)
        {
            // rotate on x-axis of the world
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(-90, 0, 0, Space.World);
                Delay();
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(90, 0, 0, Space.World);
                Delay();
            }

            // rotate on y-axis of the world
            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(0, -90, 0, Space.World);
                Delay();
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(0, 90, 0, Space.World);
                Delay();
            }
             // rotate on z-axis of the world
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(0, 0, -90, Space.World);
                Delay();
            }
            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(0, 0, 90, Space.World);
                Delay();
             }
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }

    private void Reset()
    {
        if (pressed && delay > 0)
        {
            delay -= Time.deltaTime;
        }
        if (delay < 0)
        {
            delay = 0;
            pressed = false;
        }
    }

    private void Delay()
    {
        delay = .15f;
        pressed = true;
    }

}

