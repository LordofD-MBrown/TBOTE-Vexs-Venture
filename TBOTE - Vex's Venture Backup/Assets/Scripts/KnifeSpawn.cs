using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawn : MonoBehaviour
{
    public GameObject KnifePos1;
    public GameObject KnifePos2;
    public GameObject KnifePos3;
    public GameObject KnifePos4;
    public GameObject KnifePos5;
    public GameObject KnifePos6;

    Random rnd = new Random();
    
    // Use this for initialization
    void Start ()
    {
        int getPos = Random.Range(0, 7);

        if (getPos == 0)
        {
            KnifePos1.SetActive(true);
        }
        if (getPos == 1)
        {
            KnifePos2.SetActive(true);
        }
        if (getPos == 2)
        {
            KnifePos3.SetActive(true);
        }
        if (getPos == 3)
        {
            KnifePos4.SetActive(true);
        }
        if (getPos == 4)
        {
            KnifePos5.SetActive(true);
        }
        if (getPos == 5)
        {
            KnifePos6.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
