using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Slider volumeSlider;
    float masterVolume;
    float tempVar;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public void Start()
    {
        volumeSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        tempVar= FindObjectOfType<MainMenu>().getVolume();
        volumeSlider.value = tempVar;
        masterVolume = volumeSlider.value;
        AudioListener.volume = masterVolume;
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Pause()
    {
        Debug.Log("INSIDE THE PAUSE FUNCTION");
        Debug.Log("THE PAUSE MENU IS THE OBJECT " + pauseMenuUI);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ValueChangeCheck()
    {
        Debug.Log(volumeSlider.value);
        masterVolume = volumeSlider.value;
        AudioListener.volume = masterVolume;
    }
    public void LoadMenu()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
