using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ViperScript : MonoBehaviour {
    GameObject player;
    NavMeshAgent vipermovement;
    Animator anim;
    bool isWalking = false;
    bool isIdle = true;
    bool dead = false;

    int chaseDistIntialized = 10;
	// Use this for initialization
	void Start ()
    {
        vipermovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= chaseDistIntialized && dead == false)
        {
            goafterplayer();
        }
        if (Vector3.Distance(transform.position, player.transform.position) > chaseDistIntialized)
        {
            vipermovement.enabled = false;

            isIdle = true;
            isWalking = false;
            anim.SetBool("IsIdle", isIdle);
            anim.SetBool("IsWalking", isWalking);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Torch")
        {
            vipermovement.enabled = false;
            dead = true;
            anim.SetBool("IsDying", true);
        }
    }
    void goafterplayer()
    {
        vipermovement.enabled = true;
        vipermovement.speed = 5;
        vipermovement.destination = player.transform.position;
        if (transform.position != player.transform.position)
        {

            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
        }



    }







}
