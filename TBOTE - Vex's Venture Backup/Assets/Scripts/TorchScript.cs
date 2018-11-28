using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TorchScript : MonoBehaviour {

    PlayerClass player;
    int Diming_Rate;
    float baseLight;
    bool forest = false;
    bool wait = false;

    //Public GameObjects=====
    public GameObject playerObject;
    public GameObject torch;
    public Light flame_light;
    //Torches=================
    public GameObject flame_0;
    public GameObject flame_1;
    public GameObject flame_2;
    public GameObject flame_3;
    public GameObject flame_4;
    public GameObject flame_5;
    public GameObject flame_6;
    public GameObject flame_7;
    public GameObject flame_8;
    public GameObject flame_9;
    public GameObject flame_10;
    public GameObject flame_11;
    public GameObject flame_12;
    public GameObject flame_13;
    public GameObject flame_14;
    public GameObject flame_15;
    public GameObject flame_16;
    public GameObject flame_17;
    public GameObject flame_18;
    public GameObject flame_19;
    public GameObject flame_20;
    public GameObject flame_21;
    public GameObject flame_22;
    public GameObject flame_23;
    public GameObject flame_24;
    public GameObject flame_25;
    public GameObject flame_26;
    //====================================

    void Start()
    {
        //setting instance of player class
        player = playerObject.GetComponent<PlayerClass>();
        //================================

        //Turning Torches off=====
        ClearTorches();
        //========================

        //set first torch light range
        flame_light.range = 25;
        //===========================

        //dimming process============
        StartCoroutine("torchDim");
        Time.timeScale = 1;
        //===========================
    }
    void OnEnable()
    {
        wait = false;
        player.DimmingofTorch();
    }

    void LateUpdate ()
    {
        if(wait == false)
        {
            StartCoroutine("torchDim");
            wait = true;
        }
        if(SceneManager.GetActiveScene().name == "TheTownOfBabbage")
        {
            forest = false;
            baseLight = 50;
            RenderSettings.fogEndDistance = baseLight;
        }
        else if(SceneManager.GetActiveScene().name == "TheVerionianForest(Right)")
        {
            forest = true;
            baseLight = .15f;
            RenderSettings.fogDensity = baseLight;
        }
        else
        {
            forest = false;
        }

        if (player.GetTorch() == true)
        {
            if (player.GetTorchLife() <= 400 && player.GetTorchLife() >= 385)
            {
                flame_0.SetActive(true);
                flame_1.SetActive(true);
                flame_light.range = 25;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .06f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 10f;
                }
            }
            else if (player.GetTorchLife() <= 384 && player.GetTorchLife() >= 369)
            {
                flame_0.SetActive(false);
                flame_1.SetActive(true);
                flame_2.SetActive(true);
                flame_light.range = 24;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .06333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 9.666f;
                }
            }
            else if (player.GetTorchLife() <= 368 && player.GetTorchLife() >= 353)
            {
                flame_1.SetActive(false);
                flame_2.SetActive(true);
                flame_3.SetActive(true);
                flame_light.range = 23;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .06666f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 9.333f;
                }
            }
            else if (player.GetTorchLife() <= 352 && player.GetTorchLife() >= 337)
            {
                flame_2.SetActive(false);
                flame_3.SetActive(true);
                flame_4.SetActive(true);
                flame_light.range = 22;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .07f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 9f;
                }
            }
            else if (player.GetTorchLife() <= 336 && player.GetTorchLife() >= 321)
            {
                flame_3.SetActive(false);
                flame_4.SetActive(true);
                flame_5.SetActive(true);
                flame_light.range = 21;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .07333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 8.666f;
                }
            }
            else if (player.GetTorchLife() <= 320 && player.GetTorchLife() >= 305)
            {
                flame_4.SetActive(false);
                flame_5.SetActive(true);
                flame_6.SetActive(true);
                flame_light.range = 20;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .08f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 8.333f;
                }
            }
            else if (player.GetTorchLife() <= 304 && player.GetTorchLife() >= 289)
            {
                flame_5.SetActive(false);
                flame_6.SetActive(true);
                flame_7.SetActive(true);
                flame_light.range = 19;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .08333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 8f;
                }
            }
            else if (player.GetTorchLife() <= 288 && player.GetTorchLife() >= 273)
            {
                flame_6.SetActive(false);
                flame_7.SetActive(true);
                flame_8.SetActive(true);
                flame_light.range = 18;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .08666f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 7.666f;
                }
            }
            else if (player.GetTorchLife() <= 272 && player.GetTorchLife() >= 257)
            {
                flame_7.SetActive(false);
                flame_8.SetActive(true);
                flame_9.SetActive(true);
                flame_light.range = 17;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .09f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 7.333f;
                }
            }
            else if (player.GetTorchLife() <= 256 && player.GetTorchLife() >= 241)
            {
                flame_8.SetActive(false);
                flame_9.SetActive(true);
                flame_10.SetActive(true);
                flame_light.range = 16;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .09333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 7f;
                }
            }
            else if (player.GetTorchLife() <= 240 && player.GetTorchLife() >= 225)
            {
                flame_9.SetActive(false);
                flame_10.SetActive(true);
                flame_11.SetActive(true);
                flame_light.range = 15;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .09666f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 6.666f;
                }
            }
            else if (player.GetTorchLife() <= 224 && player.GetTorchLife() >= 209)
            {
                flame_10.SetActive(false);
                flame_11.SetActive(true);
                flame_12.SetActive(true);
                flame_light.range = 14;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .10f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 6.333f;
                }
            }
            else if (player.GetTorchLife() <= 208 && player.GetTorchLife() >= 193)
            {
                flame_11.SetActive(false);
                flame_12.SetActive(true);
                flame_13.SetActive(true);
                flame_light.range = 13;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .10333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 6f;
                }           
            }
            else if (player.GetTorchLife() <= 192 && player.GetTorchLife() >= 177)
            {
                flame_12.SetActive(false);
                flame_13.SetActive(true);
                flame_14.SetActive(true);
                flame_light.range = 12;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .10666f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 5.666f;
                }
            }
            else if (player.GetTorchLife() <= 176 && player.GetTorchLife() >= 161)
            {
                flame_13.SetActive(false);
                flame_14.SetActive(true);
                flame_15.SetActive(true);
                flame_light.range = 11;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .11f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 5.333f;
                }
            }
            else if (player.GetTorchLife() <= 160 && player.GetTorchLife() >= 145)
            {
                flame_14.SetActive(false);
                flame_15.SetActive(true);
                flame_16.SetActive(true);
                flame_light.range = 10;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .11333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 5f;
                }
            }
            else if (player.GetTorchLife() <= 144 && player.GetTorchLife() >= 129)
            {
                flame_15.SetActive(false);
                flame_16.SetActive(true);
                flame_17.SetActive(true);
                flame_light.range = 9;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .11666f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 4.666f;
                }
            }
            else if (player.GetTorchLife() <= 128 && player.GetTorchLife() >= 113)
            {
                flame_16.SetActive(false);
                flame_17.SetActive(true);
                flame_18.SetActive(true);
                flame_light.range = 8;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .12f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 4.333f;
                }
            }
            else if (player.GetTorchLife() <= 112 && player.GetTorchLife() >= 97)
            {
                flame_17.SetActive(false);
                flame_18.SetActive(true);
                flame_19.SetActive(true);
                flame_light.range = 7;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .12333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 4f;
                }
            }
            else if (player.GetTorchLife() <= 96 && player.GetTorchLife() >= 81)
            {
                flame_18.SetActive(false);
                flame_19.SetActive(true);
                flame_20.SetActive(true);
                flame_light.range = 6;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .12666f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 3.666f;
                }

            }
            else if (player.GetTorchLife() <= 80 && player.GetTorchLife() >= 65)
            {
                flame_19.SetActive(false);
                flame_20.SetActive(true);
                flame_21.SetActive(true);
                flame_light.range = 5;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .13f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 3.333f;
                }
            }
            else if (player.GetTorchLife() <= 64 && player.GetTorchLife() >= 49)
            {
                flame_20.SetActive(false);
                flame_21.SetActive(true);
                flame_22.SetActive(true);
                flame_light.range = 4;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .13333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 3f;
                }

            }
            else if (player.GetTorchLife() <= 48 && player.GetTorchLife() >= 33)
            {
                flame_21.SetActive(false);
                flame_22.SetActive(true);
                flame_23.SetActive(true);
                flame_light.range = 3;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .13666f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 2.666f;
                }
            }
            else if (player.GetTorchLife() <= 32 && player.GetTorchLife() >= 17)
            {
                flame_22.SetActive(false);
                flame_23.SetActive(true);
                flame_24.SetActive(true);
                flame_light.range = 2;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .14f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 2.333f;
                }

            }
            else if (player.GetTorchLife() <= 16 && player.GetTorchLife() >= 1)
            {
                flame_23.SetActive(false);
                flame_24.SetActive(true);
                flame_25.SetActive(true);
                flame_light.range = 1;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .14333f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 2f;
                }

            }
            else if (player.GetTorchLife() == 0)
            {
                flame_24.SetActive(false);
                flame_25.SetActive(true);
                flame_26.SetActive(true);
                flame_light.range = 0;
                if (forest == true)
                {
                    RenderSettings.fogDensity = .14666f;
                }
                else
                {
                    RenderSettings.fogEndDistance = 1.666f;
                }
                StartCoroutine("torchOut");
                ClearTorches();
            }
        }
        if (SceneManager.GetActiveScene().name == "TheTownOfBabbage")
        {
            RenderSettings.fogEndDistance = baseLight;
        }
    }

    IEnumerator torchDim()
    {
      yield return new WaitForSeconds(1);
      player.DimmingofTorch();
      wait = false;

    }

    IEnumerator torchOut()
    {
        yield return new WaitForSeconds(16);
        flame_25.SetActive(false);
        flame_26.SetActive(false);
    }

    void ClearTorches()
    {
        flame_0.SetActive(false);
        flame_1.SetActive(false);
        flame_2.SetActive(false);
        flame_3.SetActive(false);
        flame_4.SetActive(false);
        flame_5.SetActive(false);
        flame_6.SetActive(false);
        flame_7.SetActive(false);
        flame_8.SetActive(false);
        flame_9.SetActive(false);
        flame_10.SetActive(false);
        flame_11.SetActive(false);
        flame_12.SetActive(false);
        flame_13.SetActive(false);
        flame_14.SetActive(false);
        flame_15.SetActive(false);
        flame_16.SetActive(false);
        flame_17.SetActive(false);
        flame_18.SetActive(false);
        flame_19.SetActive(false);
        flame_20.SetActive(false);
        flame_21.SetActive(false);
        flame_22.SetActive(false);
        flame_23.SetActive(false);
        flame_24.SetActive(false);
        flame_25.SetActive(false);
        flame_26.SetActive(false);
    }
}
