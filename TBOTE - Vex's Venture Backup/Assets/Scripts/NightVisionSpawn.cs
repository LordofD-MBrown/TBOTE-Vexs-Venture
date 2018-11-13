using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightVision : MonoBehaviour
{

    public GameObject NightVisionPos1;
    public GameObject NightVisionPos2;
    public GameObject NightVisionPos3;
    public GameObject NightVisionPos4;
    public GameObject NightVisionPos5;


    // Use this for initialization
    void Start ()
    {
        int getPos = Random.Range(0, 6);

        if (getPos == 0)
        {
            NightVisionPos1.SetActive(true);

        }
        if (getPos == 1)
        {
            NightVisionPos2.SetActive(true);
        }
        if (getPos == 2)
        {
            NightVisionPos3.SetActive(true);
        }
        if (getPos == 3)
        {
            NightVisionPos4.SetActive(true);
        }
        if (getPos == 4)
        {
            NightVisionPos5.SetActive(true);
        }
        


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
