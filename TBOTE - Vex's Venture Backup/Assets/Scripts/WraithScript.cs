using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WraithScript : MonoBehaviour {

    public GameObject player;
    public GameObject camera;
    public GameObject wraith;

    NavMeshAgent wraithMovement;
    Animator anim;

    bool isWalking = false;
    bool isAttacking = false;

    void Start ()
    {
		wraithMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
	
	void Update ()
    {
		wraithMovement.destination = player.transform.position;
        if (transform.position != player.transform.position)
        {
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
        }
    }

    
}
