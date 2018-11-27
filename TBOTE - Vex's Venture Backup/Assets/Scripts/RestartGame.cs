using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartGame : MonoBehaviour
{
    
    //bool isDead = true;                      //--- When this script is called, set bool to true
    public GameObject GameOverUI;


    public void GameOver()                   //--- enter Game Over event
    {
        //GameOverUI = GameObject.FindGameObjectWithTag("GameOverScreen");


        //GameOverUI = GameObject.FindWithTag("GameOverScreen");
        bool isDead = true;
        Debug.Log("GAME OVER");
        Debug.Log(GameOverUI.tag);

        if (isDead)                          //--- when bool is true...
        {
            Debug.Log("INSIDE IsDead CHECK");
            isDead = false;                  //--- reset to false
            Cursor.lockState = CursorLockMode.None;
            GameOverUI.SetActive(true);      //--- enable the Game Over screen
            
            //Time.timeScale = 0f;             
        }
    }

    public void RestartButton()
    {
        Debug.Log("INSIDE THE RESTART BUTTON PRESS");
        //RespawnPlayer respawnPlayer = new RespawnPlayer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameOverUI.SetActive(false);
        FindObjectOfType<RespawnPlayer>().respawn();
        //respawnPlayer.respawn();
        
    }

    public void QuitGame()
    {
        GameOverUI.SetActive(false);
        SceneManager.LoadScene(0);
        
    }

    void Awake()
    {
        /*GameObject[] objs = GameObject.FindGameObjectsWithTag("GameOverScreen");

        if (objs.Length > 1)
        {
            Destroy(GameOverUI);
        }*/
        

        DontDestroyOnLoad(GameOverUI);
    }
}
