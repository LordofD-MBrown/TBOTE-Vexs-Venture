using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseKnife : MonoBehaviour
{
    PlayerClass player;
    Animator anim;
    bool in_use;

    public GameObject playerObject;
    public GameObject knifeColider;

    // Use this for initialization
    void Start ()
    {
        player = playerObject.GetComponent<PlayerClass>();
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        RenderSettings.fogEndDistance = 2;
        if (player.GetKnife() == true)
        {
            if (in_use == false && Input.GetMouseButtonDown(0))
            {
                StartCoroutine("waitForKnifeUse");
                in_use = true;
                anim.SetBool("IsAttacking", in_use);
                for (int i = 0; i < 10; i++)
                {
                    player.DimmingofTorch();
                }
            }
        }
    }

    IEnumerator waitForKnifeUse()
    {
        player.SetInAnim(true);
        knifeColider.SetActive(true);

        yield return new WaitForSeconds(1f);
        in_use = false;
        anim.SetBool("IsAttacking", in_use);

        knifeColider.SetActive(false);
        player.SetInAnim(false);
    }
}
