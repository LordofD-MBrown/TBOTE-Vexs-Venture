using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    Animator anim;
    GameObject playerAnim;
    GameObject player;
    double torchLife;
    public GameObject respawnPoint;

    public void respawn()
    {
        Debug.Log("INSIDE RESPAWN SCRIPT FUNCTION");
        Debug.Log("THE RESPAWN POINT POSITION IS " + respawnPoint.transform.position);
        /*playerAnim = GameObject.Find("FP System");
        playerAnim.GetComponent<Animator>().SetBool("IsDying", false);
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = respawnPoint.transform.position;*/
        //FindObjectOfType<PlayerMovement>().playerRespawn();
        player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log("THE PLAYER'S POSITION IS " + player.transform.position);
        player.transform.position = respawnPoint.transform.position;
        Debug.Log("THE PLAYER'S NEW POSITION IS " + player.transform.position);
        
    }
	
}
