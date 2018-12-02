using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ObjectiveScript : MonoBehaviour {

    TextMeshProUGUI objectiveText;

	void Start ()
    {
        objectiveText = GetComponent<TextMeshProUGUI>();
	}
	
	
	void Update ()
    {
		if(SceneManager.GetActiveScene().name == "TheTownOfBabbage")
        {
            objectiveText.SetText("Tales have spread of an ancient tome, hidden away from the living.In this tome lies a secret ritual for immortality, the ultimate score for a thief such as myself. Throughout the town of Babbage, I must find a knife to protect myself in the forest, and a torch to light my way in the temple.Maybe I can find a night vision potion as well.But, if I am spotted by the guards, they will not hesitate to remove me from the castle walls...");
        }
        else if (SceneManager.GetActiveScene().name == "TheVerionianForest(Right)")
        {
            objectiveText.SetText("The Verionian Forest is known to instill madness in anyone who ventures off its path.The path itself is said to be made of cobblestone from Babbage to a nearby castle.To believe this entire tale, I must believe that along this path, I will also find a connected path made of Giant's scar tissue. Beyond that lies a path, black as death, which leads to The Abbey of St. Tempe's...");
        }
        else if (SceneManager.GetActiveScene().name == "TheAbbeyofSaintTempes")
        {
            objectiveText.SetText("The Abbey of St.Tempe's...a place so evil, the surrounding forest - and the mountain it lies upon - slowly succumbs to its darkness. The tome is said to rest at the end of a dark labyrinth, protected by the Abbey's source of evil. If this evil exists, I will have to find a way to destroy it, and escape with my reward...");
        }
	}
}
