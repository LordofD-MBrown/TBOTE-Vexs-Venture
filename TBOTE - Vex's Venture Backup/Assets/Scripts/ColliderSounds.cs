using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class ColliderSounds : MonoBehaviour {
    public Sound s;
	// Use this for initialization
    void Awake()
    {
        s.source = gameObject.AddComponent<AudioSource>();
        s.source.clip = s.clip;

        s.source.volume = 1f;
        s.source.pitch = 1f;
        s.source.loop = s.loop;
        s.source.spatialBlend = 1f;
    }
	
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            s.source.Play();
        }
    }
}
