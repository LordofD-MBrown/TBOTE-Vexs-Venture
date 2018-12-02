using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RatScript : MonoBehaviour {
    GameObject player;
    NavMeshAgent ratmovement;
    Animator anim;
    bool isWalking = false;
    bool isIdle = true;
    float distFromPlayer;
    bool dead = false;

    int chaseDistIntialized = 18;
    
    
    // Use this for initialization
	void Start ()
    {
        ratmovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");

        distFromPlayer = Vector3.Distance(transform.position, player.transform.position);




	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Vector3.Distance(transform.position,player.transform.position)<=chaseDistIntialized && dead==false )
        {
            goafterplayer();
        }
        if (Vector3.Distance(transform.position, player.transform.position) > chaseDistIntialized)
        {
            ratmovement.enabled = false;
            
            isIdle = true;
            isWalking = false;
            anim.SetBool("IsIdle", isIdle);
            anim.SetBool("IsWalking", isWalking);
        }








    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Knife")
        {   
            ratmovement.enabled = false;
            dead = true;
            anim.SetBool("IsDying", true);
        }
    }

    void goafterplayer()
    {
        ratmovement.enabled = true;
        ratmovement.speed = 5;
        ratmovement.destination = player.transform.position;
        if (transform.position!=player.transform.position)
        {
           
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
        }
        


    }








}



