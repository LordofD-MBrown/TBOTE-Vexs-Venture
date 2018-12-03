using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class ScareSounds : MonoBehaviour {
    public Sound s;

	// Use this for initialization
	void Awake ()
    {
        s.source = gameObject.AddComponent<AudioSource>();
        s.source.clip = s.clip;

        s.source.volume = 1f;
        s.source.pitch = 1f;
        s.source.loop = s.loop;
        s.source.spatialBlend = 1f;
        s.source.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
