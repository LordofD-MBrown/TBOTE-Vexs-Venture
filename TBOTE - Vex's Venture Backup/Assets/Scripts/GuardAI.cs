using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAI : MonoBehaviour {

    NavMeshAgent guardMovement;
    Animator anim;

    bool isRunning = false;
    bool trackPlayer = false;
    bool playerCaught = false;

    GameObject player;



    // Use this for initialization
    void Start()
    {
        guardMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (trackPlayer == true && transform.position != player.transform.position)
        {
            guardMovement.destination = player.transform.position;
            isRunning = true;
            anim.SetBool("IsRunning", isRunning);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        if(name == "Player")
        {
            Debug.Log("Player is now being tracked");
            trackPlayer = true;
        }

    }
}
