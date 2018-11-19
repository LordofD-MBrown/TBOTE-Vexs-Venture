using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GuardAI : MonoBehaviour {

    NavMeshAgent guardMovement;
    Animator anim;

    bool isRunning = false;
    bool trackPlayer = false;
    bool playerCaught = false;

    GameObject player;

    int invisbleHealth = 50;



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
            
        }

        if (invisbleHealth == 0)
        {
            playerCaught = true;
        }

        if (playerCaught == true)
        {
            DontDestroyOnLoad(player);
            SceneManager.LoadScene("TheVerionianForest(Right)");
            Vector3 loadPosition = new Vector3(20f, 5.58f, 781.78f);
            player.transform.position = loadPosition;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        if(name == "Player")
        {
            Debug.Log("Player is now being tracked");
            trackPlayer = true;

            isRunning = true;
            anim.SetBool("IsRunning", isRunning);
            guardMovement.speed = 6.5f;
        }
        

        if (trackPlayer == true && isRunning == true)
        {
            invisbleHealth = invisbleHealth - 10;
        }

    }
}
