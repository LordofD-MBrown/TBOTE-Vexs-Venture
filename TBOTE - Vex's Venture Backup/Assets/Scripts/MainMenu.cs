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
        StartCoroutine(Waiting());

       
        
        
    }
	public float getVolume()
    {
        return masterVolume;
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
    IEnumerator Waiting()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        FindObjectOfType<AudioManager>().Pause("TitleScreen");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Play("TownTheme");
        print(Time.time);
    }

}
