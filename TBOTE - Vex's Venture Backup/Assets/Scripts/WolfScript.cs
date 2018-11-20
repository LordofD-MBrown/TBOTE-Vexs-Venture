﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WolfScript : MonoBehaviour {
    GameObject player;
    GameObject wolfobj;
    NavMeshAgent wolfMovement;
    Animator anim;
    bool isWalking = false;
    public Transform wolf;
    int maxDist = 25;
    int minDist = 8;

    void Start()
    {
        wolfMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
        wolfobj = GameObject.Find("wolf01");
    }

    void Update()
    {
        wolfMovement.destination = wolfobj.transform.position;
        wolfMovement.speed = 4;
        if(Vector3.Distance(transform.position, wolfobj.transform.position) >= minDist)
        {
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
            if (Vector3.Distance(transform.position, wolfobj.transform.position) <= minDist)
            {
                goafterplayer();


            }

        }

       // wolfMovement.destination = player.transform.position;
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Torch")
        {
            wolfMovement.enabled = false;
            anim.SetBool("IsDying", true);            
        }
    }

   void goafterplayer()
    {
        wolfMovement.destination = player.transform.position;
        if (transform.position!=player.transform.position)
        {
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
        }
    }


}
