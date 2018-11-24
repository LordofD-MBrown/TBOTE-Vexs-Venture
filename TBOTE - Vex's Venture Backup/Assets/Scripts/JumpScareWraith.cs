﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpScareWraith : MonoBehaviour {

    public GameObject player;
    public GameObject wraith;
    public GameObject torch;
    public GameObject knife;
    public GameObject potion;

    PlayerMovement playerMovement;
    ItemHandler itemHandler;

    int randomNumber;

	void Start ()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
        itemHandler = player.GetComponent<ItemHandler>();
        playerMovement.enabled = false;
        itemHandler.enabled = false;
        torch.SetActive(false);
        knife.SetActive(false);
        potion.SetActive(false);
        

        StartCoroutine("JumpScareTimmer");
    }

    IEnumerator JumpScareTimmer()
    {
        randomNumber = Random.Range(1, 5);
        yield return new WaitForSeconds(randomNumber);
        wraith.gameObject.SetActive(true);
    }

}
