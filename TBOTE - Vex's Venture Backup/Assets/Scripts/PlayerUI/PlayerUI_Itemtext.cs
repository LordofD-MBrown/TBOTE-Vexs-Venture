using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI_Itemtext : MonoBehaviour
{

    TextMeshProUGUI itemtext;

	// Use this for initialization
	void Start ()
    {
        itemtext = gameObject.GetComponent<TextMeshProUGUI>();
        itemtext.SetText("");
	}
	
}
