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
        /*playerAnim = GameObject.Find("FP System");
        playerAnim.GetComponent<Animator>().SetBool("IsDying", false);
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = respawnPoint.transform.position;*/
        FindObjectOfType<PlayerMovement>().playerRespawn();
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = respawnPoint.transform.position;
        
    }
	
}
