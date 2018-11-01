using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speedLeftRight = 2f;
    public float speedUpDown = 2f;
    private float leftRight = 0f;
    private float upDown = 0f;
    GameObject character;
    // Use this for initialization
    void Start()
    {

        character = GameObject.Find("Player");
    }


    void Update()
    {
        //RenderSettings.fogDensity;
        Cursor.lockState = CursorLockMode.Locked;
        leftRight += speedLeftRight * Input.GetAxis("Mouse X");
        upDown += speedUpDown * Input.GetAxis("Mouse Y");

        character.transform.eulerAngles = new Vector3(0f, leftRight, 0f);
    }

    void LateUpdate()
    {
        transform.eulerAngles = new Vector3(upDown * -1, leftRight, 0f);
    }
}
