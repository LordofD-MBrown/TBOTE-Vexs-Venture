using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareWraith : MonoBehaviour {

    public GameObject player;
    CameraMovement cameraMovement;
    PlayerMovement playerMovement;

	void Start ()
    {
        cameraMovement = player.GetComponent<CameraMovement>();
        playerMovement = player.GetComponent<PlayerMovement>();
    }

	void Update ()
    {
		
	}

    IEnumerator JumpScareTimmer()
    {
        yield return new WaitForSeconds(1);
    }
}
