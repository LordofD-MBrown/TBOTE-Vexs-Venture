using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDarkOneRangeScript : MonoBehaviour
{
    public GameObject theDarkOne;

    TheDarkOneAI AI;
    void Start ()
    {
        AI = theDarkOne.GetComponent<TheDarkOneAI>();
    }
	

	void Update ()
    {
		
	}

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "Player")
        {
            AI.SetRangeCollision(true);
        }
    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.name == "Player")
        {
            AI.SetRangeCollision(false);
        }
    }
}
