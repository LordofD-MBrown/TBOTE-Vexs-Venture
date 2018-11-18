using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchPickup : MonoBehaviour
{
    public GameObject playerTorch;

	// Use this for initialization
	void Start ()
    {
		
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
            playerTorch.SetActive(true);

            Destroy(gameObject);
        }
    }
}
