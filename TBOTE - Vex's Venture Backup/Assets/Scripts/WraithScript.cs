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

    void Start ()
    {
		wraithMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
        camera = GameObject.Find("FP System");
        wraithSpawning = GameObject.Find("WraithGod");
        wraithSpawn = wraithSpawning.GetComponent<WraithSpawn>();
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
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Torch")
        {
            wraithMovement.enabled = false;
            anim.SetBool("IsDying", true);
            StartCoroutine("WraithDeath");
            
        }
    }

    IEnumerator WraithDeath()
    {
        yield return new WaitForSeconds(2f);
        wraithSpawn.WraithDeath();
        Destroy(gameObject);
    }


}
