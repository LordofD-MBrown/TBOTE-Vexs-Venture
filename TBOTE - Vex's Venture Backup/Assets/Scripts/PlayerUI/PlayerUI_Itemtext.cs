using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerUI_Itemtext : MonoBehaviour
{

    float range = 5f;
    public Camera camera;
    public GameObject player;

    PlayerClass playerClass;
    GameObject TheDarkOne;
    TextMeshProUGUI itemtext;

	void Start ()
    {
        playerClass = player.GetComponent<PlayerClass>();
        itemtext = gameObject.GetComponent<TextMeshProUGUI>();
        itemtext.SetText("");
	}

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "TheAbbeyofSaintTempes")
        {
            TheDarkOne = GameObject.Find("The Dark One");
        }
            
        Hover();
    }

    void Hover()
    {
        RaycastHit hitInformation;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hitInformation, range))
        {
            Debug.Log(hitInformation.transform.name);
            Debug.Log(hitInformation.transform.tag);

            if (hitInformation.transform.name == "TorchSpawn")
            {
                itemtext.SetText("Torch");
            }
            else if (hitInformation.transform.tag == "Knife" && playerClass.GetKnife() == false)
            {
                itemtext.SetText("Knife");
            }
            else if (hitInformation.transform.tag == "Potion" && playerClass.GetNightPotion() == false)
            {
                itemtext.SetText("Potion");
            }
            else if (hitInformation.transform.name == "PortaltoForest")
            {
                itemtext.SetText("The Verionian Forest");
            }
            else if (hitInformation.transform.name == "PortaltoAbbey")
            {
                itemtext.SetText("The Abbey of St. Tempes");
            }
            else if (hitInformation.transform.name == "DarkTome" && TheDarkOne.activeInHierarchy == true)
            {
                itemtext.SetText("The Tome of Imortality (Protected)");
            }
            else if (hitInformation.transform.name == "DarkTome" && TheDarkOne.activeInHierarchy == false)
            {
                itemtext.SetText("The Tome of Imortality (Protected)");
            }
            else
            {
                itemtext.SetText("");
            }
        }
    }
}
