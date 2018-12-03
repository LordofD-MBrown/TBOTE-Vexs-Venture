using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerPointer : MonoBehaviour {

    float range = 5f;

    public Camera camera;
    public GameObject player;
    public GameObject p_menu;
    public GameObject p_ui;
    GameObject TheDarkOne;

    PlayerClass playerinfo;

    //--- Michael -- Pause Menu -- Start
    bool GameIsPaused = false;
    PauseMenu pauseMenu;

    void start()
    {
        pauseMenu = p_menu.GetComponent<PauseMenu>();
        p_menu.SetActive(false);
    }
    //--- Michael -- Pause Menu -- End
	void Update ()
    {
        if (SceneManager.GetActiveScene().name == "TheAbbeyofSaintTempes")
        {
            TheDarkOne = GameObject.Find("Black Hole");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();   
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            playerinfo.SetKnife(true);
            playerinfo.SetTorch(true);
            DontDestroyOnLoad(player);           
            SceneManager.LoadScene("TheAbbeyofSaintTempes");
            Vector3 loadPosition = new Vector3(-32.5f, 2.535f, 60.14f);
            player.transform.position = loadPosition;
            FindObjectOfType<AudioManager>().Pause("TownTheme");
            FindObjectOfType<AudioManager>().Pause("ForestTheme");
            FindObjectOfType<AudioManager>().Play("AbbeyTheme");
        }
        //--- Michael -- Pause Menu -- Start
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pauseMenu = new PauseMenu();
            if (!GameIsPaused)
            {
                //Time.timeScale = 1f;
                p_menu.SetActive(true);
                FindObjectOfType<PlayerMovement>().pauseGame(true);
                p_ui.SetActive(false);
                //pauseMenu.Resume();
                GameIsPaused = true;
            }
            else if (GameIsPaused)
            {
                //Time.timeScale = 0f;
                p_menu.SetActive(false);
                FindObjectOfType<PlayerMovement>().pauseGame(false);
                FindObjectOfType<SFXManager>().Pause("Footsteps");
                p_ui.SetActive(true);
                //pauseMenu.Pause();
                GameIsPaused = false;
            }
        }
        //--- Michael -- Pause Menu -- End
    }

    void Interact()
    {
        playerinfo = player.GetComponent<PlayerClass>();
        RaycastHit hitInformation;

        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hitInformation, range))
        {
            Debug.Log(hitInformation.transform.name);
            Debug.Log(hitInformation.transform.tag);

            if(hitInformation.transform.name == "PortaltoForest")
            {
                FindObjectOfType<AudioManager>().Pause("TownTheme");
                FindObjectOfType<AudioManager>().Play("ForestTheme");  
                DontDestroyOnLoad(player);
                SceneManager.LoadScene("TheVerionianForest(Right)");
                Vector3 loadPosition = new Vector3(20f, 5.58f, 781.78f);
                player.transform.position = loadPosition;
            }
            if(hitInformation.transform.name == "PortaltoAbbey")
            {
                FindObjectOfType<AudioManager>().Pause("ForestTheme");
                FindObjectOfType<AudioManager>().Play("AbbeyTheme");
                DontDestroyOnLoad(player);
                SceneManager.LoadScene("TheAbbeyofSaintTempes");
                Vector3 loadPosition = new Vector3(-32.5f, 2.535f, 60.14f);
                player.transform.position = loadPosition;
            }
            if (hitInformation.transform.name == "TorchSpawn")
            {
                playerinfo.SetTorch(true);
                hitInformation.transform.gameObject.SetActive(false);
            }
            if(hitInformation.transform.tag == "Knife")
            {
                playerinfo.SetKnife(true);
                hitInformation.transform.gameObject.SetActive(false);             
            }
            if(hitInformation.transform.tag == "Potion")
            {
                playerinfo.GrabPotion();
                hitInformation.transform.gameObject.SetActive(false);
            }
            if (hitInformation.transform.name == "DarkTome" && TheDarkOne.activeInHierarchy == true)
            {
                playerinfo.SetTome(true);
                hitInformation.transform.gameObject.SetActive(false);
            }
            if (hitInformation.transform.tag == "Win" && playerinfo.GetTome() == true)
            {
                playerinfo.SetEscaped(true);
                DontDestroyOnLoad(player);
                SceneManager.LoadScene("TheVerionianForest(Right)");
                Vector3 loadPosition = new Vector3(283.3315f, 102.8619f, 155.7085f);
                player.transform.position = loadPosition;
            }
        }
    }
    
}
