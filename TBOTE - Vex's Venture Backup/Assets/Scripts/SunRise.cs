using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRise : MonoBehaviour {

    GameObject player;
    PlayerClass playerinfo;

    Animator anim;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player");
        playerinfo = player.GetComponent<PlayerClass>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(playerinfo.GetEscaped() == true)
        {
            anim.SetBool("Ending", true);
        }
	}
}
