using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    int fallingDistance = 0;
    bool death = false;

    public float speed = 5f;
    public float gravity = 30f;
    public Vector3 move = Vector3.zero;

    public GameObject camera;
    public GameObject potion;
    public GameObject torch;
    public GameObject knife;

    JumpScareWraith jumpScareWraith;
    CharacterController controller;
    ItemHandler itemHandler;
    PlayerClass player;
    Animator anim;
    CameraMovement cameraMovement;

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        player = gameObject.GetComponent<PlayerClass>();
        jumpScareWraith = camera.GetComponent<JumpScareWraith>();
        anim = camera.GetComponent<Animator>();
        cameraMovement = camera.GetComponent<CameraMovement>();
        itemHandler = gameObject.GetComponent<ItemHandler>();
    }

    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        if (controller.isGrounded && death == false)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            move = transform.TransformDirection(move);
            move *= speed;
            
            if (fallingDistance >= 30)
            {
                anim.SetBool("IsDying", true);
                cameraMovement.enabled = false;
                itemHandler.enabled = false;
                death = true;
                torch.SetActive(false);
                knife.SetActive(false);
                potion.SetActive(false);
                
                RenderSettings.fogEndDistance = 3f;

                //Michael - Testing GameOver script - BEGINNING
                FindObjectOfType<RestartGame>().GameOver();
                //Michael - Testing GameOver script - END
            }
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {

                FindObjectOfType<SFXManager>().Play("Footsteps");
            }
            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)&& !Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.A)  && !Input.GetKeyDown(KeyCode.S)  && !Input.GetKeyDown(KeyCode.D) )
            {
               
                    FindObjectOfType<SFXManager>().Pause("Footsteps");
            }

            fallingDistance = 0;
        }

        if(!controller.isGrounded)
        {
            fallingDistance++;
        }


        move.y -= gravity * Time.deltaTime;

        controller.Move(move * Time.deltaTime);
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wraith")
        {
            RenderSettings.fogEndDistance = 3;
            jumpScareWraith.enabled = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "TheDarkOne")
        {
            anim.SetBool("IsDying", true);
            cameraMovement.enabled = false;
            itemHandler.enabled = false;
            death = true;
            torch.SetActive(false);
            knife.SetActive(false);
            potion.SetActive(false);
        }
        if(other.gameObject.name == "Black Hole")
        {
            anim.SetBool("IsDying", true);
            cameraMovement.enabled = false;
            itemHandler.enabled = false;
            death = true;
            torch.SetActive(false);
            knife.SetActive(false);
            potion.SetActive(false);
        }
    }
    //--- Michael --- Testing respawn Start
    public void playerRespawn()
    {
        anim.SetBool("IsDying", false);
        cameraMovement.enabled = true;
        itemHandler.enabled = true;
        death = false;
        

        /*playerAnim = GameObject.Find("FP System");
        playerAnim.GetComponent<Animator>().SetBool("IsDying", false);
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = respawnPoint.transform.position;*/
    }
    //--- Michael --- Testing respawn End
}