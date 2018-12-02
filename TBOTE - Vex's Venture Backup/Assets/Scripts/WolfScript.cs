using System.Collections;
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
    int minDist = 15;

    void Start()
    {
        wolfMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
        wolfobj = GameObject.Find("wolf01");
    }

    void Update()
    {
        
        if(Vector3.Distance(transform.position, wolfobj.transform.position) >= minDist)
        {
            wolfMovement.destination = wolfobj.transform.position;
            wolfMovement.speed = 4;
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
            if (Vector3.Distance(transform.position, wolfobj.transform.position) <= minDist)
            {
                wolfMovement.isStopped = true;
                goafterplayer();


            }

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
        wolfMovement.isStopped = false;
        Debug.Log("Going After Player");
        wolfMovement.destination = player.transform.position;
        if (transform.position!=player.transform.position)
        {
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
        }
    }


}
