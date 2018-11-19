using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GuardPatrolling : MonoBehaviour
{
    NavMeshAgent guardMovement;

    Animator anim;

    bool isRunning = false;
    bool trackPlayer = false;
    bool playerCaught = false;

    GameObject player;

    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;
    public GameObject pos5;
    public GameObject pos6;
    public GameObject pos7;
    public GameObject pos8;
    public GameObject pos9;

    int posNum = 0;
    int invisbleHealth = 50;


    // Use this for initialization
    void Start ()
    {
        guardMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (trackPlayer == true && transform.position != player.transform.position)
        {
            guardMovement.destination = player.transform.position;

        }

        if(invisbleHealth == 0)
        {
            playerCaught = true;
        }

        if(playerCaught == true)
        {
            DontDestroyOnLoad(player);
            SceneManager.LoadScene("TheVerionianForest(Right)");
            Vector3 loadPosition = new Vector3(20f, 5.58f, 781.78f);
            player.transform.position = loadPosition;
        }

        Debug.Log(posNum);

        if(trackPlayer == false)
        {
            if (posNum == 0)
            {
                guardMovement.destination = pos1.transform.position;
            }
            if (posNum == 1)
            {
                guardMovement.destination = pos2.transform.position;
            }
            if (posNum == 2)
            {
                guardMovement.destination = pos3.transform.position;
            }
            if (posNum == 3)
            {
                guardMovement.destination = pos4.transform.position;
            }
            if (posNum == 4)
            {
                guardMovement.destination = pos5.transform.position;
            }
            if (posNum == 5)
            {
                guardMovement.destination = pos6.transform.position;
            }
            if (posNum == 6)
            {
                guardMovement.destination = pos7.transform.position;
            }
            if (posNum == 7)
            {
                guardMovement.destination = pos8.transform.position;
            }
            if (posNum == 8)
            {
                guardMovement.destination = pos9.transform.position;
            }
            if (posNum == 9)
            {
                guardMovement.destination = pos1.transform.position;
            }
        }

        
        
    }

    private void OnTriggerEnter(Collider other)
    {


        string name = other.gameObject.name;

        string posName1 = other.gameObject.name;
        string posName2 = other.gameObject.name;
        string posName3 = other.gameObject.name;
        string posName4 = other.gameObject.name;
        string posName5 = other.gameObject.name;
        string posName6 = other.gameObject.name;
        string posName7 = other.gameObject.name;
        string posName8 = other.gameObject.name;
        string posName9 = other.gameObject.name;
        string posName10 = other.gameObject.name;

        if (posNum == 0 && other.tag == "1")
        {
            posNum = 1;
        }
        if (posNum == 1 && other.tag == "2")
        {
            posNum = 2;
        }
        if (posNum == 2 && other.tag == "3")
        {
            posNum = 3;
        }
        if (posNum == 3 && other.tag == "4")
        {
            posNum = 4;
        }
        if (posNum == 4 && other.tag == "5")
        {
            posNum = 5;
        }
        if (posNum == 5 && other.tag == "6")
        {
            posNum = 6;
        }
        if (posNum == 6 && other.tag == "7")
        {
            posNum = 7;
        }
        if (posNum == 7 && other.tag == "8")
        {
            posNum = 8;
        }
        if (posNum == 8 && other.tag == "9")
        {
            posNum = 0;
        }





        if (name == "Player")
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
