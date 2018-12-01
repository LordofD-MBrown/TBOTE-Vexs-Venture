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
    Animator anim;

    public GameObject jumpScareWraith;


    void Start()
    {
        character = GameObject.Find("Player");
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
        //Cursor.visible = false; --- Michael testing
    }

    void Update()
    {
        if (jumpScareWraith.activeInHierarchy == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            
            leftRight += speedLeftRight * Input.GetAxis("Mouse X");
            upDown += speedUpDown * Input.GetAxis("Mouse Y");

            if (upDown > 60)
            {
                upDown = 60;
            }
            else if (upDown < -60)
            {
                upDown = -60;
            }
            //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            //{
            //    FindObjectOfType<SFXManager>().Play("Footsteps");

            //}
            //if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
            //{
            //    FindObjectOfType<SFXManager>().Pause("Footsteps");
            //}
        }
        else if (jumpScareWraith.activeInHierarchy == true)
        {
            StartCoroutine("PlayerDeathAnimation");
        }

        character.transform.eulerAngles = new Vector3(0f, leftRight, 0f);
    }

    void LateUpdate()
    {
        transform.eulerAngles = new Vector3(upDown * -1, leftRight, 0f);
    }

    IEnumerator PlayerDeathAnimation()
    {
        yield return new WaitForSeconds(6);
        anim.SetBool("IsDying", true);


        //Michael - Testing GameOver script - BEGINNING
        FindObjectOfType<RestartGame>().GameOver();
        //Michael - Testing GameOver script - END
    }
}
