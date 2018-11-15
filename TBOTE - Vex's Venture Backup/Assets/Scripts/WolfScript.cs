using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WolfScript : MonoBehaviour {
    GameObject player;
    NavMeshAgent wolfMovement;
    Animator anim;
    bool isWalking = false;

    void Start()
    {
        wolfMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");        
    }

    void Update()
    {
        wolfMovement.destination = player.transform.position;
        if (transform.position != player.transform.position)
        {
            isWalking = true;
            anim.SetBool("IsWalking", isWalking);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Torch")
        {
            wolfMovement.enabled = false;
            anim.SetBool("IsDying", true);            
        }
    }

   


}
