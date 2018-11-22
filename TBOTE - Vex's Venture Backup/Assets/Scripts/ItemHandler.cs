using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemHandler : MonoBehaviour {

    PlayerClass player;

    public GameObject player_ui;

    public GameObject torch;
    public GameObject knife;

    int currentItem = 0;

	// Use this for initialization

	void Start ()
    {
        player = player_ui.GetComponent<PlayerClass>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetMouseButtonDown(1) && player.GetInAnim() == false)
        {
            
            currentItem++;
            Debug.Log(currentItem);

            if(currentItem == 1 && player.GetTorch() == true)
            {
                turnOffItems();
                torch.SetActive(true);
                Debug.Log("Torch");
            }
            else if(currentItem == 2 && player.GetKnife() == true)
            {
                turnOffItems();
                knife.SetActive(true);
                Debug.Log("Knife");
            }

            else
            {
                if (SceneManager.GetActiveScene().name == "TheTownOfBabbage")
                {
                    RenderSettings.fogEndDistance = 50f;
                }
                else if(SceneManager.GetActiveScene().name == "TheVerionianForest(Right)")
                {
                    RenderSettings.fogDensity = .15f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 1.666f;
                }
                turnOffItems();
                currentItem = 0;
            }
        }
	}

    void turnOffItems()
    {
        torch.SetActive(false);
        knife.SetActive(false);
    }
}
