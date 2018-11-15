using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderScript : MonoBehaviour {
    GameObject player;
    NavMeshAgent spiderMovement;
    Animator anim;
    bool isWalking = false;

    void Start()
    {
        spiderMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        spiderMovement.destination = player.transform.position;
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
            spiderMovement.enabled = false;
            anim.SetBool("IsDying", true);
        }
    }
}
