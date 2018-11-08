using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpScareWraith : MonoBehaviour {

    public GameObject player;
    public GameObject camera;
    public GameObject wraith;

    CameraMovement cameraMovement;
    PlayerMovement playerMovement;

    int randomNumber;

	void Start ()
    {
        cameraMovement = camera.GetComponent<CameraMovement>();
        playerMovement = player.GetComponent<PlayerMovement>();
    }

	void Update ()
    {
        cameraMovement.enabled = false;
        playerMovement.enabled = false;
        StartCoroutine("JumpScareTimmer");
	}

    IEnumerator JumpScareTimmer()
    {
        randomNumber = Random.Range(1, 5);
        yield return new WaitForSeconds(randomNumber);
        wraith.gameObject.SetActive(true);
    }
}
