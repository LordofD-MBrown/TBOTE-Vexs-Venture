using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTorchScript : MonoBehaviour {

    PlayerClass player;
    Animator anim;
    bool in_use;

    public GameObject playerObject;
    public GameObject torchCollider;
    public Light torchLight;

    void Start ()
    {
       player = playerObject.GetComponent<PlayerClass>();
       anim = GetComponent<Animator>();
       Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update ()
    {
            if (in_use == false && Input.GetMouseButtonDown(0))
            {
                StartCoroutine("waitForTorchUse");
                in_use = true;
                anim.SetBool("LeftClick", in_use);
                for (int i = 0; i < 10; i++)
                {
                    player.DimmingofTorch();
                }
            }
	}

    IEnumerator waitForTorchUse()
    {
        player.SetInAnim(true);
        if (torchLight.range > 0)
        {
            torchCollider.SetActive(true);
        }

        yield return new WaitForSeconds(1f);
        in_use = false;
        anim.SetBool("LeftClick", in_use);

        if (torchLight.range > 0)
        {
            torchCollider.SetActive(false);
        }
        player.SetInAnim(false);
       
    }
}
