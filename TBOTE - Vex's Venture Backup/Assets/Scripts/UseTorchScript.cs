using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTorchScript : MonoBehaviour {
    Animator anim;
    bool in_use;

    public GameObject torchCollider;
    public Light torchLight;

    void Start ()
    {
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
        }
	}

    IEnumerator waitForTorchUse()
    {
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
       
    }
}
