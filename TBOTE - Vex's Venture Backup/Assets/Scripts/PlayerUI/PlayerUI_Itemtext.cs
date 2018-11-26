using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI_Itemtext : MonoBehaviour
{

    float range = 5f;
    public Camera camera;
    TextMeshProUGUI itemtext;

	void Start ()
    {
        itemtext = gameObject.GetComponent<TextMeshProUGUI>();
        itemtext.SetText("");
	}

    void Update()
    {
        Hover();
    }

    void Hover()
    {
        RaycastHit hitInformation;

        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hitInformation, range))
        {
            Debug.Log(hitInformation.transform.name);
            Debug.Log(hitInformation.transform.tag);

            if (hitInformation.transform.name == "TorchSpawn")
            {
                itemtext.SetText("Torch");
            }
            else if (hitInformation.transform.tag == "Knife")
            {
                itemtext.SetText("Knife");
            }
            else if (hitInformation.transform.tag == "Potion")
            {
                itemtext.SetText("Potion");
            }
            else if (hitInformation.transform.name == "PortaltoForest")
            {
                itemtext.SetText("The Verionian Forest");
            }
            else if (hitInformation.transform.name == "PortaltoAbbey")
            {
                itemtext.SetText("The Abbey of St. Tempes");
            }
            else
            {
                itemtext.SetText("");
            }
        }
    }
}
