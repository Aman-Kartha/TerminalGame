﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    [SerializeField]
    bool check;
   public void playGame()
    {
        SceneManager.LoadScene(5);
    }
   
    public void resetGame()
    {
        SceneManager.LoadScene(1);
    }

    public void playTutorial()
    {
        SceneManager.LoadScene(4);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.W))
        {
            if (check)
                playTutorial();
            else
                playGame();

        }
    }
}
