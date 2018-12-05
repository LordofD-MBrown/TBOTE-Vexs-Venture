using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TheDarkOneAI : MonoBehaviour {

    GameObject player;
    NavMeshAgent theDarkOne;
    Animator anim;

    public GameObject MeleeAttack;
    public GameObject RangeAttack;
    public GameObject Black_Hole;
    public GameObject Wraiths;

   

    bool activeAnimation = false;
    bool isWalking = false;
    bool isMelee = false;
    bool isPain = false;
    bool isRange = false;
    bool isDying = false;
    bool theDarkOneDeath = false;
    bool playerInMeleeRange = false;
    bool playerKnifeTome = false;
    bool playerInRange = false;

	void Start ()
    {
        player = GameObject.Find("Player");
        theDarkOne = gameObject.GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        StartCoroutine("TheDarkOneSpawn");
	}
	
	void Update ()
    {
        if (theDarkOneDeath == false)
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
                    StartCoroutine("TheDarkLordMeleeDamage");
                }
                else if (playerInMeleeRange == false)
                {
                    isMelee = false;
                }
                anim.SetBool("IsMelee", isMelee);

                if (playerInRange == true)
                {
                    isRange = true;
                    StartCoroutine("TheDarkOneRange");
                    StartCoroutine("TheDarkOneRangeDamage");
                }
                else if(playerInRange == false)
                {
                    isRange = false;
                }
                anim.SetBool("IsRange", isRange);
            }

            if (playerKnifeTome == true)
            {
                player.transform.position = new Vector3(220.8f, -88.01f, -103.9f);
                player.transform.rotation = new Quaternion(0, 90, 0, 0);
                StartCoroutine("TheDarkOnePain");
                isPain = true;
            }
            else if (playerKnifeTome == false)
            {
                isPain = false;
            }
            anim.SetBool("IsPain", isPain);

            if (activeAnimation == true)
            {
                theDarkOne.speed = 0f;
            }
            else if (activeAnimation == false)
            {
                theDarkOne.speed = 5f;
            }
        }
        else if(theDarkOneDeath == true)
        {
            RenderSettings.fog = false;
            isDying = true;
            anim.SetBool("IsDying", isDying);
            StartCoroutine("Death");
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

    public void GetTheDarkOneDeath(bool t_theDarkOneDeath)
    {
        theDarkOneDeath = t_theDarkOneDeath;
    }

    public void SetRangeCollision(bool t_playerInRange)
    {
        playerInRange = t_playerInRange;
    }

    public bool SetDarkOneDeath()
    {
        return theDarkOneDeath;
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
        yield return new WaitForSeconds(3f);
        activeAnimation = false;
    }

    IEnumerator TheDarkLordMeleeDamage()
    {
        yield return new WaitForSeconds(1.5f);
        MeleeAttack.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        MeleeAttack.SetActive(false);
    }

    IEnumerator TheDarkOnePain()
    {
        activeAnimation = true;
        yield return new WaitForSeconds(4f);
        activeAnimation = false;
    }

    IEnumerator TheDarkOneRange()
    {
        activeAnimation = true;
        yield return new WaitForSeconds(4f);
        activeAnimation = false;
    }

    IEnumerator TheDarkOneRangeDamage()
    {
        yield return new WaitForSeconds(1.5f);
        RangeAttack.SetActive(true);
        yield return new WaitForSeconds(2f);
        RangeAttack.SetActive(false);
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(6f);
        RenderSettings.fog = false;
        Wraiths.SetActive(false);
        Black_Hole.SetActive(true);
        //gameObject.SetActive(false);
    }

    


}
