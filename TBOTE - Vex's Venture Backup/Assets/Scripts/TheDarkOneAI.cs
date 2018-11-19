using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TheDarkOneAI : MonoBehaviour {

    GameObject player;
    NavMeshAgent theDarkOne;
    Animator anim;

    public GameObject meleeAttackSensor;

    bool activeAnimation = false;
    bool isWalking = false;
    bool isMelee = false;
    bool isPain = false;
    bool playerInMeleeRange = false;
    bool playerKnifeTome = false;

	void Start ()
    {
        player = GameObject.Find("Player");
        theDarkOne = gameObject.GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        StartCoroutine("TheDarkOneSpawn");
	}
	
	void Update ()
    {
        if (activeAnimation == false)
        {
            theDarkOne.destination = player.transform.position;
            if (gameObject.transform.position != player.transform.position && activeAnimation == false)
            {
                isWalking = true;
            }
            else
            {
                isWalking = false;
            }
            anim.SetBool("IsWalking", isWalking);

            if (playerInMeleeRange == true)
            {
                isMelee = true;
                StartCoroutine("TheDarkOneMelee");
            }
            else if (playerInMeleeRange == false)
            {
                isMelee = false;
            }
            anim.SetBool("IsMelee", isMelee);
        }

        if(playerKnifeTome == true)
        {
            player.transform.position = new Vector3(220.8f, -88.01f, -103.9f);
            player.transform.rotation = new Quaternion(0, 90, 0, 0);
            StartCoroutine("TheDarkOnePain");
            isPain = true;
        }
        else if(playerKnifeTome == false)
        {
            isPain = false;
        }
        anim.SetBool("IsPain", isPain);

        if(activeAnimation == true)
        {
            theDarkOne.speed = 0f;
        }
        else if(activeAnimation == false)
        {
            theDarkOne.speed = 5f;
        }


	}

    public void SetMeleeCollision(bool t_playerInMeleeRange)
    {
        playerInMeleeRange = t_playerInMeleeRange;
    }

    public void CheckPlayerKnifeTome(bool t_playerKnifeTome)
    {
        playerKnifeTome = t_playerKnifeTome;
    }


    IEnumerator TheDarkOneSpawn()
    {
        activeAnimation = true;
        yield return new WaitForSeconds(6f);
        activeAnimation = false;
    }

    IEnumerator TheDarkOneMelee()
    {
        activeAnimation = true;
        yield return new WaitForSeconds(4f);
        activeAnimation = false;
    }

    IEnumerator TheDarkOnePain()
    {
        activeAnimation = true;
        yield return new WaitForSeconds(4f);
        activeAnimation = false;
    }

    


}
