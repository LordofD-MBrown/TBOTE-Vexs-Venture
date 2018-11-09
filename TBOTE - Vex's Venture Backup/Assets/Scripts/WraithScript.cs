using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WraithScript : MonoBehaviour {

    GameObject player;
    GameObject camera;
    public GameObject wraith;

    NavMeshAgent wraithMovement;
    Animator anim;

    bool isWalking = false;

    void Start ()
    {
		wraithMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
        camera = GameObject.Find("FP System");
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
