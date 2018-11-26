using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI_EnableTorch : MonoBehaviour
{
    public GameObject player;
    public GameObject torchtext;
    public GameObject torchlife;

    PlayerClass playerClass;

	void Start ()
    {
        playerClass = player.GetComponent<PlayerClass>();
	}
	
	void Update ()
    {
        if (playerClass.GetTorch() == true)
        {
            torchtext.SetActive(true);
            torchlife.SetActive(true);
        }
	}
}
