using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PauseScriptVolumeSlider : MonoBehaviour {
    public Slider volumeSlider;
    float masterVolume;
	// Use this for initialization
	void Start ()
    {
        volumeSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        masterVolume = FindObjectOfType<MainMenu>().getVolume();
        volumeSlider.value = masterVolume;
        AudioListener.volume = masterVolume;
    }
    public void ValueChangeCheck()
    {
        Debug.Log(volumeSlider.value);
        masterVolume = volumeSlider.value;
        AudioListener.volume = masterVolume;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
