using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPointer : MonoBehaviour {

    float range = 10f;

    public Camera camera;
    public GameObject player;

    PlayerClass playerinfo;

    void start()
    {
        
    }
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
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
                DontDestroyOnLoad(player);
                SceneManager.LoadScene("TheVerionianForest(Right)");
                Vector3 loadPosition = new Vector3(20f, 5.58f, 781.78f);
                player.transform.position = loadPosition;
            }
            if(hitInformation.transform.name == "PortaltoAbbey")
            {
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
        }
    }
}
