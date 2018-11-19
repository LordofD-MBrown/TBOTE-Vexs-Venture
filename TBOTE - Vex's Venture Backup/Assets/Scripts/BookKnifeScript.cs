using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookKnifeScript : MonoBehaviour
{
    public GameObject TheDarkOne;

    TheDarkOneAI AI;

    int numberOfStabs = 1;

	void Start ()
    {
        AI = TheDarkOne.GetComponent<TheDarkOneAI>();
	}
	
	
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Knife")
        {
            if (numberOfStabs <= 2)
            {
                AI.CheckPlayerKnifeTome(true);
                numberOfStabs++;
            }
            else if(numberOfStabs == 3)
            {
                AI.GetTheDarkOneDeath(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Knife")
        {
            AI.CheckPlayerKnifeTome(false);
        }
    }

}
