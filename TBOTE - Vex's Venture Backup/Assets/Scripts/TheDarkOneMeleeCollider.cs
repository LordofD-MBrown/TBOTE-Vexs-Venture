using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDarkOneMeleeCollider : MonoBehaviour {

    public GameObject theDarkOne;

    TheDarkOneAI AI;

	void Start ()
    {
        AI = theDarkOne.GetComponent<TheDarkOneAI>();
	}

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.name == "Player")
        {
            AI.SetMeleeCollision(true);
        }
    }
    public void OnTriggerExit(Collider collision)
    {
        if(collision.name == "Player")
        {
            AI.SetMeleeCollision(false);
        }
    }
}
