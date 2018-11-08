using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WraithScript : MonoBehaviour {

    public GameObject player;

    //PlayerMovement playerMovement;
    NavMeshAgent wraith;
    Animator anim;

    bool isWalking = false;
    bool isAttacking = false;

    void Start ()
    {
        //playerMovement = player.GetComponent<PlayerMovement>();
		wraith = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
	
	void Update ()
    {
		wraith.destination = player.transform.position;
        if (transform.position != player.transform.position)
        {
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if(hit.gameObject == player)
        {
            //isAttacking = true;
            //anim.SetBool("IsAttacking", isAttacking);
            //playerMovement.enabled = false;
        }
    }
}
