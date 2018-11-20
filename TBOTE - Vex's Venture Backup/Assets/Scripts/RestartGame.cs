using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame : MonoBehaviour
{
    bool isDead = true;                      //--- When this script is called, set bool to true
    GameObject GameOverUI;

  
    public void GameOver()                   //--- enter Game Over event
    {
        GameOverUI = GameObject.Find("GameOverScreen");
        Debug.Log("GAME OVER");

        if (isDead)                          //--- when bool is true...
        {
            isDead = false;                  //--- reset to false
            GameOverUI.SetActive(true);      //--- enable the Game Over screen
            //Time.timeScale = 0f;             
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
