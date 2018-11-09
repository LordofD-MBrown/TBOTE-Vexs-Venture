using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumpScareWraith : MonoBehaviour {

    public GameObject player;
    public GameObject wraith;
    public GameObject torch;

    PlayerMovement playerMovement;

    int randomNumber;

	void Start ()
    {
        playerMovement = player.GetComponent<PlayerMovement>();

        playerMovement.enabled = false;
        torch.SetActive(false);
        StartCoroutine("JumpScareTimmer");
    }

    IEnumerator JumpScareTimmer()
    {
        randomNumber = Random.Range(1, 5);
        yield return new WaitForSeconds(randomNumber);
        wraith.gameObject.SetActive(true);
    }

}
