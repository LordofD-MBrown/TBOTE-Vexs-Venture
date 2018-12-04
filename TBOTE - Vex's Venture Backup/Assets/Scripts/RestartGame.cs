using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame : MonoBehaviour
{
    
    public GameObject GameOverUI;
    public GameObject player;


    public void GameOver()                   //--- enter Game Over event
    {
        /*bool isDead = true;
        Debug.Log("GAME OVER");
        Debug.Log(GameOverUI.tag);

        if (isDead)                          //--- when bool is true...
        {*/
            //Debug.Log("INSIDE IsDead CHECK");
            //isDead = false;                  //--- reset to false
            Cursor.lockState = CursorLockMode.None;
            GameOverUI.SetActive(true);      //--- enable the Game Over screen
                       
        //}
    }

    public void RestartButton()
    {
        Debug.Log("INSIDE THE RESTART BUTTON PRESS");
        SceneManager.LoadScene(0);
        player.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        GameOverUI.SetActive(false);       
        
    }

    public void QuitGame()
    {
        player.SetActive(false);
        Application.Quit();
        
    }

    /*void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameOverScreen");

        if (objs.Length > 1)
        {
            Destroy(GameOverUI);
        }
        
        //if (SceneManager.GetActiveScene() == "TS)
        DontDestroyOnLoad(GameOverUI);

    }*/

}
