using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public int portalNumber;

    private void OnCollisionEnter(Collision collision)
    {
        if (portalNumber == 1)
        {
            SceneManager.LoadScene("Form 1");
        }
        else if (portalNumber == 2)
        {
            SceneManager.LoadScene("Form 2");
        }
        else if (portalNumber == 3)
        {
            SceneManager.LoadScene("Form 3");
        }
        else if (portalNumber == 4)
        {
            SceneManager.LoadScene("Form 4");
        }
        else if (portalNumber == 5)
        {
            SceneManager.LoadScene("Form 5");
        }
        else if (portalNumber == 6)
        {
            SceneManager.LoadScene("Last level");
        }
    }
}
