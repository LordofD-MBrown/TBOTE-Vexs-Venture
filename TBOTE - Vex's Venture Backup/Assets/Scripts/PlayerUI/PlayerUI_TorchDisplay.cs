using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI_TorchDisplay : MonoBehaviour
{
    double torchlife = 0;

    public GameObject player;

    PlayerClass playerClass;
    TextMeshProUGUI torchtext;

    void Start ()
    {
        torchtext = gameObject.GetComponent<TextMeshProUGUI>();
        playerClass = player.GetComponent<PlayerClass>();
	}
	

	void Update ()
    {
        torchlife = playerClass.GetTorchLife();
        torchtext.SetText(((int)((torchlife / 400) * 100)) + "%");
	}
}
