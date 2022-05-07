using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    [SerializeField]
    bool check;

    [SerializeField]
    bool check2;

    [SerializeField]
    bool check3;


    [SerializeField]
    bool check4;

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
    public void hardReset()
    {
        SceneManager.LoadScene(0);
    }


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.Q)))
        {
            if (check4 && !check3)
            {
                playTutorial();
            }
        }

        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.W)||(Input.GetKeyDown(KeyCode.Q)) )
        {
            if(check3 )
            {
                hardReset();
            }
        }


        if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.W) )&& !check4 && !check3)
        {
            if (check && !check3)
                playTutorial();
            else
                playGame();

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (check2 && !check3)
            {
                playTutorial();
            }
        }

    }
}
