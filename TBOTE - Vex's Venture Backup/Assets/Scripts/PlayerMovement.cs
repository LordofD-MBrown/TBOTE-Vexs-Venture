using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    int fallingDistance = 0;
    bool death = false;
    bool jump = false;
    bool forest = false;
    bool first = false;
    bool firstpass = false;
    public float speed = 5f;
    public float gravity = 30f;
    public float jumpStart;
    public float jumpEnd;

    public Vector3 move = Vector3.zero;

    public GameObject camera;
    public GameObject potion;
    public GameObject torch;
    public GameObject knife;
    public GameObject wraith;
    public GameObject playerUI;
    public GameObject winScreen;

    JumpScareWraith jumpScareWraith;
    CharacterController controller;
    ItemHandler itemHandler;
    PlayerClass player;
    Animator anim;
    CameraMovement cameraMovement;
    PlayerPointer pp;
   

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        player = gameObject.GetComponent<PlayerClass>();
        jumpScareWraith = camera.GetComponent<JumpScareWraith>();
        anim = camera.GetComponent<Animator>();
        cameraMovement = camera.GetComponent<CameraMovement>();
        itemHandler = gameObject.GetComponent<ItemHandler>();
        pp = camera.GetComponent<PlayerPointer>();
        
    }

    void Update()
    {        
        movePlayer();
        if(player.GetEscaped() == true)
        {
            cameraMovement.enabled = false;
            pp.enabled = false;
            playerUI.SetActive(false);
            torch.SetActive(false);
            knife.SetActive(false);
            potion.SetActive(false);
            winScreen.SetActive(true);
        }
    }

    void movePlayer()
    {
        if (controller.isGrounded && death == false)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            move = transform.TransformDirection(move);
            move *= speed;   
            if(jump == true)
            {
                jumpEnd = player.transform.position.y;
            }
            Debug.Log(jumpStart - jumpEnd);
            if (jump == true && (jumpStart - jumpEnd) > .25f)
            {
               Debug.Log("Fall");
               anim.SetBool("IsDying", true);
               cameraMovement.enabled = false;
               itemHandler.enabled = false;
               death = true;
               torch.SetActive(false);
               knife.SetActive(false);
               potion.SetActive(false);
               //Michael - Testing GameOver script - BEGINNING
                FindObjectOfType<RestartGame>().GameOver();
               //Michael - Testing GameOver script - END
            }
            else if (jump == true)
            {
                jump = false;
            }
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                FindObjectOfType<SFXManager>().Play("Footsteps");   
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                FindObjectOfType<SFXManager>().Pause("Footsteps");   
            }            
        }

        if (!controller.isGrounded)
        {
           jump = true;
           jumpStart = player.transform.position.y;
        }  
        
        //=============================HeartBeat=========================================
        if(SceneManager.GetActiveScene().name == "TheAbbeyofSaintTempes")
        {
            try
            {
                wraith = GameObject.FindWithTag("Wraith");
                float d = Vector3.Distance(wraith.transform.position, transform.position);
                //Debug.Log((1/(d-10)) * 10); --- Michael commented out for console spam
                FindObjectOfType<SFXManager>().Volume("HeartBeat", ((1 / (d - 10)) * 10));
            }
            catch
            {
                Debug.Log("Error");
            }
            if (firstpass == false)
            {
                FindObjectOfType<SFXManager>().Play("HeartBeat");
                firstpass = true;
            }
                  
        }
        //================================================================================
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
        if(other.gameObject.tag == "Hole")
        {
            anim.SetBool("IsDying", true);
            cameraMovement.enabled = false;
            itemHandler.enabled = false;
            death = true;
            torch.SetActive(false);
            knife.SetActive(false);
            potion.SetActive(false);
        }
        //--- Michael --- Water Death -- Start
        if(other.gameObject.tag == "Water")
        {
            anim.SetBool("IsDying", true);
            cameraMovement.enabled = false;
            itemHandler.enabled = false;
            death = true;
            torch.SetActive(false);
            knife.SetActive(false);
            potion.SetActive(false);
            //FindObjectOfType<RestartGame>().GameOver();
        }
        //--- Michael --- Water Death -- End
        if (other.gameObject.tag=="rat")
        {
            anim.SetBool("IsDying", true);
            cameraMovement.enabled = false;
            itemHandler.enabled = false;
            death = true;
            torch.SetActive(false);
            knife.SetActive(false);
            potion.SetActive(false);
            FindObjectOfType<RestartGame>().GameOver();
        }
        if(other.gameObject.tag=="wolf")
        {
            anim.SetBool("IsDying", true);
            cameraMovement.enabled = false;
            itemHandler.enabled = false;
            death = true;
            torch.SetActive(false);
            knife.SetActive(false);
            potion.SetActive(false);
            FindObjectOfType<RestartGame>().GameOver();
        }
        
    }
    //--- Michael --- Testing respawn -- Start
    /*public void playerRespawn()
    {
        anim.SetBool("IsDying", false);
        cameraMovement.enabled = true;
        itemHandler.enabled = true;
        death = false;
        
    }*/
    //--- Michael --- Testing respawn -- End


    //--- Michael --- Testing PauseGame -- Start
    public void pauseGame(bool isPaused)
    {
        if (isPaused)
        {
            cameraMovement.enabled = false;
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            cameraMovement.enabled = true;
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
        }               
    }
    //--- Michael --- Testing PauseGame -- End
}