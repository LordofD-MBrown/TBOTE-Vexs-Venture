using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPointer : MonoBehaviour {

    float range = 10f;

    public Camera camera;
    public GameObject player;


	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
	}

    void Interact()
    {
        RaycastHit hitInformation;

        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hitInformation, range))
        {
            Debug.Log(hitInformation.transform.name);

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
        }
    }
}
