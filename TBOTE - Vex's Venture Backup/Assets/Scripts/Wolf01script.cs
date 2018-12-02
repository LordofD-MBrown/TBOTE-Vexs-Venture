﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wolf01script : MonoBehaviour {
    GameObject player;
    GameObject wolfobj;
    NavMeshAgent wolfMovement;
    Animator anim;
    bool isWalking = false;
    public Transform wolf;
    int maxDist = 25;
    int minDist = 15;
    bool wolvesfound = false;
    void Start()
    {
        wolfMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
        wolfobj = GameObject.Find("wolf02");
    }

    void Update()
    {
        

        if (Vector3.Distance(transform.position,wolfobj.transform.position)>=minDist&&wolvesfound==false)
        {
            wolfMovement.destination = wolfobj.transform.position;
            
            wolfMovement.speed = 4;
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
            
            if (Vector3.Distance(transform.position, wolfobj.transform.position) <= minDist)
            {
                wolvesfound = true;
                wolfMovement.isStopped = true;

                goafterplayer();


            }

        }
        else
        {
            goafterplayer();
        }
        // wolfMovement.destination = player.transform.position;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Knife")
        {
            wolfMovement.enabled = false;
            anim.SetBool("IsDying", true);
        }
    }

    void goafterplayer()
    {
       // Debug.Log("Other Wolves Going after player");
        wolfMovement.isStopped = false;
        wolfMovement.destination = player.transform.position;
        if (transform.position != player.transform.position)
        {
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
        }
    }


}
