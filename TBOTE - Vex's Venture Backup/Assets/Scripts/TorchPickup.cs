using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchPickup : MonoBehaviour
{
    public GameObject player;

    PlayerClass playerinfo;

	// Use this for initialization
	void Start ()
    {
        playerinfo = player.GetComponent<PlayerClass>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        if (name == "Player")
        {
            playerinfo.SetTorch(true);
            Destroy(gameObject);
        }
    }
}
