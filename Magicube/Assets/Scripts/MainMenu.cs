using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "button_level1":
                SceneManager.LoadScene("Level1");
                break;
            case "button_level2":
                SceneManager.LoadScene("Main");
                break;
            case "button_level3":
                SceneManager.LoadScene("Main");
                break;
        }
    }

}
