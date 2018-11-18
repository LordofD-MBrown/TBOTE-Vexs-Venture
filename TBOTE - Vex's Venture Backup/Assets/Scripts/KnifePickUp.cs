using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifePickUp : MonoBehaviour
{
    public GameObject playerKnife;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        if (name == "Player")
        {
            playerKnife.SetActive(true);
            Destroy(gameObject);
        }
    }
}
