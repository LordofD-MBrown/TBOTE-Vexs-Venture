using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemHandler : MonoBehaviour {

    PlayerClass player;

    public GameObject player_ui;

    public GameObject torch;
    public GameObject knife;
    public GameObject potion;

    int currentItem = 0;

	// Use this for initialization

	void Start ()
    {
        player = player_ui.GetComponent<PlayerClass>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        bool item = false;
        if (Input.GetMouseButtonDown(1) && player.GetInAnim() == false)
        {
            
            currentItem++;

            if(currentItem == 1 && player.GetTorch() == true)
            {
                item = true;
                turnOffItems();
                torch.SetActive(true);
                Debug.Log("Torch");
            }
            else if (currentItem == 1 && player.GetTorch() != true)
            {
                currentItem++;
            }

            if(currentItem == 2 && player.GetKnife() == true)
            {
                item = true;
                turnOffItems();
                knife.SetActive(true);
                Debug.Log("Knife");
            }
            else if (currentItem == 2 && player.GetKnife() != true)
            {
                currentItem++;
            }

            if(currentItem == 3 && player.GetNightPotion() == true)
            {
                item = true;
                turnOffItems();
                potion.SetActive(true);
                Debug.Log("Potion");
            }
            else if (currentItem == 3 && player.GetNightPotion() != true)
            {
                currentItem++;
            }

            if (item == false)
            {
                turnOffItems();
                currentItem = 0;
            }

            if (SceneManager.GetActiveScene().name == "TheTownOfBabbage" && torch.activeInHierarchy == false)
            {
                RenderSettings.fogEndDistance = 50f;
            }
            else if(SceneManager.GetActiveScene().name == "TheVerionianForest(Right)" && torch.activeInHierarchy == false)
            {
                RenderSettings.fogDensity = .15f;
            }
            else if(torch.activeInHierarchy == false)
            {
                RenderSettings.fogEndDistance = 1.666f;
            }
        }
	}

    void turnOffItems()
    {
        torch.SetActive(false);
        knife.SetActive(false);
        potion.SetActive(false);
    }
}
