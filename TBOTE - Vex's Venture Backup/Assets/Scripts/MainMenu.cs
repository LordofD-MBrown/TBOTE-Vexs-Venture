using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("TitleScreen");
    }
    public void PlayGame()
    {
        FindObjectOfType<SFXManager>().Play("TitleScreenPlay");
        FindObjectOfType<AudioManager>().Pause("TitleScreen");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
