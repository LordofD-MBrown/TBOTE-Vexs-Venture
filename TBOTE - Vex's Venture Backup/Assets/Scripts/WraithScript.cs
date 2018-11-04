using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WraithScript : MonoBehaviour {

    public GameObject player;
    NavMeshAgent wraith;
    Animator anim;

    bool IsWalking = false;

    void Start ()
    {
		wraith = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
	
	void Update ()
    {
		wraith.destination = player.transform.position;
        if (transform.position != player.transform.position)
        {
            IsWalking = true;
            anim.SetBool("IsWalking", IsWalking);
        }
        else
        {
            IsWalking = false;
            anim.SetBool("IsWalking", IsWalking);
        }
    }
}
