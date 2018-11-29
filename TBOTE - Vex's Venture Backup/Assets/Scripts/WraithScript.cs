using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WraithScript : MonoBehaviour {

    GameObject player;
    GameObject camera;
    GameObject wraithSpawning;

    public GameObject wraith;

    NavMeshAgent wraithMovement;
    WraithSpawn wraithSpawn;
    Animator anim;

    bool isWalking = false;
    bool death = false;

    void Start ()
    {
		wraithMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
        camera = GameObject.Find("FP System");
        wraithSpawning = GameObject.Find("WraithGod");
        wraithSpawn = wraithSpawning.GetComponent<WraithSpawn>();
        wraithMovement.speed = 10;
    }
	
	void Update ()
    {
        if (death == false)
        {
            wraithMovement.destination = player.transform.position;
            wraithMovement.speed = 5;
            if (transform.position != player.transform.position)
            {
                isWalking = true;
                anim.SetBool("IsWalking", isWalking);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Torch")
        {
            wraithMovement.enabled = false;
            death = true;
            anim.SetBool("IsDying", true);
            StartCoroutine("WraithDeath");
            
        }
    }

    IEnumerator WraithDeath()
    {
        yield return new WaitForSeconds(1f);
        wraithSpawn.WraithDeath();
        Destroy(gameObject);
    }


}
