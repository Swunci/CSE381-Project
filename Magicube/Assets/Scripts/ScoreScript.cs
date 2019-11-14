﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour


{
    public static int scoreValue = 0;
    public static int lifeValue = 1;
    Text score;
    Text life;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        life = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        life.text = "Lives: " + lifeValue;
        if (lifeValue <= 0)
        {
            SceneManager.LoadScene("Main Menu");
        }
        score.text = "Score: " + scoreValue;
    }
}
