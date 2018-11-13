using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WraithSpawn : MonoBehaviour {

    int wraithSpawn_1;
    int wraithSpawn_2;

    int numberAdded = 0;

    bool spawning = true;
    bool wraith1Active = false;
    bool wraith2Active = false;
    bool wraith3Active = false;
    bool wraith4Active = false;
    bool wraith5Active = false;
    bool wraith6Active = false;
    bool wraith7Active = false;
    bool wraith8Active = false;
    bool wraith9Active = false;
    bool wraith10Active = false;
    bool wraith11Active = false;
    bool wraith12Active = false;
    bool wraith13Active = false;
    bool wraith14Active = false;
    bool wraith15Active = false;
    bool wraith16Active = false;
    bool wraith17Active = false;
    bool wraith18Active = false;
    bool wraith19Active = false;
    bool wraith20Active = false;
    bool wraith21Active = false;
    bool wraith22Active = false;
    bool wraith23Active = false;
    bool wraith24Active = false;
    bool wraith25Active = false;
    bool wraith26Active = false;
    bool wraith27Active = false;
    bool wraith28Active = false;
    bool wraith29Active = false;
    bool wraith30Active = false;

    public GameObject wraith1;
    public GameObject wraith2;
    public GameObject wraith3;
    public GameObject wraith4;
    public GameObject wraith5;
    public GameObject wraith6;
    public GameObject wraith7;
    public GameObject wraith8;
    public GameObject wraith9;
    public GameObject wraith10;
    public GameObject wraith11;
    public GameObject wraith12;
    public GameObject wraith13;
    public GameObject wraith14;
    public GameObject wraith15;
    public GameObject wraith16;
    public GameObject wraith17;
    public GameObject wraith18;
    public GameObject wraith19;
    public GameObject wraith20;
    public GameObject wraith21;
    public GameObject wraith22;
    public GameObject wraith23;
    public GameObject wraith24;
    public GameObject wraith25;
    public GameObject wraith26;
    public GameObject wraith27;
    public GameObject wraith28;
    public GameObject wraith29;
    public GameObject wraith30;

    void Start ()
    {
		
	}

  public void WraithDeath()
    {
        while (spawning)
        {
            wraithSpawn_1 = Random.Range(0, 30);
            wraithSpawn_2 = Random.Range(0, 30);

            if (wraithSpawn_1 == 1 || wraithSpawn_2 == 1 && wraith1Active == false)
            {
                wraith1.SetActive(true);
                wraith1Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 2 || wraithSpawn_2 == 2 && wraith2Active == false)
            {
                wraith2.SetActive(true);
                wraith2Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 3 || wraithSpawn_2 == 3 && wraith3Active == false)
            {
                wraith3.SetActive(true);
                wraith3Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 4 || wraithSpawn_2 == 4 && wraith4Active == false)
            {
                wraith4.SetActive(true);
                wraith4Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 5 || wraithSpawn_2 == 5 && wraith5Active == false)
            {
                wraith5.SetActive(true);
                wraith5Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 6 || wraithSpawn_2 == 6 && wraith6Active == false)
            {
                wraith6.SetActive(true);
                wraith6Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 7 || wraithSpawn_2 == 7 && wraith7Active == false)
            {
                wraith7.SetActive(true);
                wraith7Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 8 || wraithSpawn_2 == 8 && wraith8Active == false)
            {
                wraith8.SetActive(true);
                wraith8Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 9 || wraithSpawn_2 == 9 && wraith9Active == false)
            {
                wraith9.SetActive(true);
                wraith9Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 10 || wraithSpawn_2 == 10 && wraith10Active == false)
            {
                wraith10.SetActive(true);
                wraith10Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 11 || wraithSpawn_2 == 11 && wraith11Active == false)
            {
                wraith11.SetActive(true);
                wraith11Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 12 || wraithSpawn_2 == 12 && wraith12Active == false)
            {
                wraith12.SetActive(true);
                wraith12Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 13 || wraithSpawn_2 == 13 && wraith13Active == false)
            {
                wraith13.SetActive(true);
                wraith13Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 14 || wraithSpawn_2 == 14 && wraith14Active == false)
            {
                wraith14.SetActive(true);
                wraith14Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 15 || wraithSpawn_2 == 15 && wraith15Active == false)
            {
                wraith15.SetActive(true);
                wraith15Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 16 || wraithSpawn_2 == 16 && wraith16Active == false)
            {
                wraith16.SetActive(true);
                wraith16Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 17 || wraithSpawn_2 == 17 && wraith17Active == false)
            {
                wraith17.SetActive(true);
                wraith17Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 18 || wraithSpawn_2 == 18 && wraith18Active == false)
            {
                wraith18.SetActive(true);
                wraith18Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 19 || wraithSpawn_2 == 19 && wraith19Active == false)
            {
                wraith19.SetActive(true);
                wraith19Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 20 || wraithSpawn_2 == 20 && wraith20Active == false)
            {
                wraith20.SetActive(true);
                wraith20Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 21 || wraithSpawn_2 == 21 && wraith21Active == false)
            {
                wraith21.SetActive(true);
                wraith21Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 22 || wraithSpawn_2 == 22 && wraith22Active == false)
            {
                wraith22.SetActive(true);
                wraith22Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 23 || wraithSpawn_2 == 23 && wraith23Active == false)
            {
                wraith23.SetActive(true);
                wraith23Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 24 || wraithSpawn_2 == 24 && wraith24Active == false)
            {
                wraith24.SetActive(true);
                wraith24Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 25 || wraithSpawn_2 == 25 && wraith25Active == false)
            {
                wraith25.SetActive(true);
                wraith25Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 26 || wraithSpawn_2 == 26 && wraith26Active == false)
            {
                wraith26.SetActive(true);
                wraith26Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 27 || wraithSpawn_2 == 27 && wraith27Active == false)
            {
                wraith27.SetActive(true);
                wraith27Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 28 || wraithSpawn_2 == 28 && wraith28Active == false)
            {
                wraith28.SetActive(true);
                wraith28Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 29 || wraithSpawn_2 == 29 && wraith29Active == false)
            {
                wraith29.SetActive(true);
                wraith29Active = true;
                numberAdded++;
            }
            if (wraithSpawn_1 == 30 || wraithSpawn_2 == 30 && wraith30Active == false)
            {
                wraith30.SetActive(true);
                wraith30Active = true;
                numberAdded++;
            }
            if(numberAdded >= 2)
            {
                spawning = false;
            }
        }
        numberAdded = 0;
        spawning = true;
    }
}
