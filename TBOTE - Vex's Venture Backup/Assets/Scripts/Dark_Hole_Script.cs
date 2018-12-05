using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dark_Hole_Script : MonoBehaviour
{

    Vector3 BlackHole;
    CharacterController BlackHoleController;
    GameObject player;
    public int Expansion_Rate;

    void Start()
    {
        BlackHoleController = gameObject.GetComponent<CharacterController>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        BlackHole = transform.localScale;
        BlackHole.x += Time.deltaTime * Expansion_Rate;
        BlackHole.y += Time.deltaTime * Expansion_Rate;
        BlackHole.z += Time.deltaTime * Expansion_Rate;
        transform.localScale = BlackHole;
    }   
}
