using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GuardAI : MonoBehaviour {
   // public AudioClip clip;
    public Sound s;
    

    
    NavMeshAgent guardMovement;
    Animator anim;

    bool isRunning = false;
    bool trackPlayer = false;
    bool playerCaught = false;

    GameObject player;

    int invisbleHealth = 50;

    [HideInInspector]
    public AudioSource source;
    void Awake()
    {
        s.source = gameObject.AddComponent<AudioSource>();
        s.source.clip = s.clip;

        s.source.volume = 1f;
        s.source.pitch = 1f;
        s.source.loop = s.loop;
        s.source.spatialBlend = 1f;
       
    }
    // Use this for initialization
    void Start()
    {
        guardMovement = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (trackPlayer == true && transform.position != player.transform.position)
        {
            
            //FindObjectOfType<SFXManager>().Play("GuardFootsteps");
            guardMovement.destination = player.transform.position;
            
        }

        if (invisbleHealth == 0)
        {
            playerCaught = true;
        }

        if (playerCaught == true)
        {
            s.source.Pause();
            FindObjectOfType<AudioManager>().Pause("TownTheme");
           // FindObjectOfType<SFXManager>().Pause("GuardFootsteps");
            DontDestroyOnLoad(player);
            SceneManager.LoadScene("TheVerionianForest(Right)");
            Vector3 loadPosition = new Vector3(20f, 5.58f, 781.78f);
            player.transform.position = loadPosition;
            FindObjectOfType<AudioManager>().Play("ForestTheme");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        if(name == "Player")
        {   
            s.source.Play();
            Debug.Log("Player is now being tracked");
            trackPlayer = true;

            isRunning = true;
            anim.SetBool("IsRunning", isRunning);
            guardMovement.speed = 6.5f;
        }
        

        if (trackPlayer == true && isRunning == true)
        {
            invisbleHealth = invisbleHealth - 10;
        }

    }
   
   
}
