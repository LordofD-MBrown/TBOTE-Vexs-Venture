using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkPotion : MonoBehaviour
{
    PlayerClass player;
    Animator anim;
    bool in_use;

    public GameObject playerObject;
    void Start ()
    {
        player = playerObject.GetComponent<PlayerClass>();
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
    }

	void Update ()
    {
        
        if (player.GetNightPotion() == true)
        {
            if (in_use == false && Input.GetMouseButtonDown(0))
            {
                StartCoroutine("waitForDrinkUse");
                in_use = true;
                anim.SetBool("IsDrinking", in_use);
            }
        }
    }

    IEnumerator waitForDrinkUse()
    {
        player.SetInAnim(true);

        yield return new WaitForSeconds(1f);
        player.usePotion();
        in_use = false;
        anim.SetBool("IsDrinking", in_use);

        player.SetInAnim(false);
        gameObject.SetActive(false);
    }
}
