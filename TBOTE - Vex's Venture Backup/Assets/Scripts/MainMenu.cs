using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Slider volumeSlider;
    float masterVolume;
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("TitleScreen");
        volumeSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        masterVolume = volumeSlider.value;
        AudioListener.volume = masterVolume;

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

    public void ValueChangeCheck()
    {
        Debug.Log(volumeSlider.value);
        masterVolume = volumeSlider.value;
        AudioListener.volume = masterVolume;
    }
}
