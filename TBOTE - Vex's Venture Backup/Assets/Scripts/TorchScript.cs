using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour {

    PlayerClass player;
    int Diming_Rate;

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
        //========================

        //set first torch light range
        flame_light.range = 25;
        //===========================

        //dimming process============
        StartCoroutine("torchDim");
        Time.timeScale = 1;
        //===========================
    }

    void LateUpdate ()
    {
        if(player.GetTorch() == true)
        {
            if (player.GetTorchLife() == 400)
            {
                flame_0.SetActive(true);
                flame_1.SetActive(true);
                flame_light.range = 25;
                RenderSettings.fogEndDistance = 10f;
            }
            else if (player.GetTorchLife() == 384)
            {
                flame_0.SetActive(false);
                flame_1.SetActive(true);
                flame_2.SetActive(true);
                flame_light.range = 24;
                RenderSettings.fogEndDistance = 9.666f;
            }
            else if (player.GetTorchLife() == 368)
            {
                flame_1.SetActive(false);
                flame_2.SetActive(true);
                flame_3.SetActive(true);
                flame_light.range = 23;
                RenderSettings.fogEndDistance = 9.333f;
            }
            else if (player.GetTorchLife() == 352)
            {
                flame_2.SetActive(false);
                flame_3.SetActive(true);
                flame_4.SetActive(true);
                flame_light.range = 22;
                RenderSettings.fogEndDistance = 9f;
            }
            else if (player.GetTorchLife() == 336)
            {
                flame_3.SetActive(false);
                flame_4.SetActive(true);
                flame_5.SetActive(true);
                flame_light.range = 21;
                RenderSettings.fogEndDistance = 8.666f;
            }
            else if (player.GetTorchLife() == 320)
            {
                flame_4.SetActive(false);
                flame_5.SetActive(true);
                flame_6.SetActive(true);
                flame_light.range = 20;
                RenderSettings.fogEndDistance = 8.333f;
            }
            else if (player.GetTorchLife() == 304)
            {
                flame_5.SetActive(false);
                flame_6.SetActive(true);
                flame_7.SetActive(true);
                flame_light.range = 19;
                RenderSettings.fogEndDistance = 8f;
            }
            else if (player.GetTorchLife() == 288)
            {
                flame_6.SetActive(false);
                flame_7.SetActive(true);
                flame_8.SetActive(true);
                flame_light.range = 18;
                RenderSettings.fogEndDistance = 7.666f;
            }
            else if (player.GetTorchLife() == 272)
            {
                flame_7.SetActive(false);
                flame_8.SetActive(true);
                flame_9.SetActive(true);
                flame_light.range = 17;
                RenderSettings.fogEndDistance = 7.333f;
            }
            else if (player.GetTorchLife() == 256)
            {
                flame_8.SetActive(false);
                flame_9.SetActive(true);
                flame_10.SetActive(true);
                flame_light.range = 16;
                RenderSettings.fogEndDistance = 7f;
            }
            else if (player.GetTorchLife() == 240)
            {
                flame_9.SetActive(false);
                flame_10.SetActive(true);
                flame_11.SetActive(true);
                flame_light.range = 15;
                RenderSettings.fogEndDistance = 6.666f;

            }
            else if (player.GetTorchLife() == 224)
            {
                flame_10.SetActive(false);
                flame_11.SetActive(true);
                flame_12.SetActive(true);
                flame_light.range = 14;
                RenderSettings.fogEndDistance = 6.333f;

            }
            else if (player.GetTorchLife() == 208)
            {
                flame_11.SetActive(false);
                flame_12.SetActive(true);
                flame_13.SetActive(true);
                flame_light.range = 13;
                RenderSettings.fogEndDistance = 6f;

            }
            else if (player.GetTorchLife() == 192)
            {
                flame_12.SetActive(false);
                flame_13.SetActive(true);
                flame_14.SetActive(true);
                flame_light.range = 12;
                RenderSettings.fogEndDistance = 5.666f;

            }
            else if (player.GetTorchLife() == 176)
            {
                flame_13.SetActive(false);
                flame_14.SetActive(true);
                flame_15.SetActive(true);
                flame_light.range = 11;
                RenderSettings.fogEndDistance = 5.333f;

            }
            else if (player.GetTorchLife() == 160)
            {
                flame_14.SetActive(false);
                flame_15.SetActive(true);
                flame_16.SetActive(true);
                flame_light.range = 10;
                RenderSettings.fogEndDistance = 5f;

            }
            else if (player.GetTorchLife() == 144)
            {
                flame_15.SetActive(false);
                flame_16.SetActive(true);
                flame_17.SetActive(true);
                flame_light.range = 9;
                RenderSettings.fogEndDistance = 4.666f;

            }
            else if (player.GetTorchLife() == 128)
            {
                flame_16.SetActive(false);
                flame_17.SetActive(true);
                flame_18.SetActive(true);
                flame_light.range = 8;
                RenderSettings.fogEndDistance = 4.333f;

            }
            else if (player.GetTorchLife() == 112)
            {
                flame_17.SetActive(false);
                flame_18.SetActive(true);
                flame_19.SetActive(true);
                flame_light.range = 7;
                RenderSettings.fogEndDistance = 4f;

            }
            else if (player.GetTorchLife() == 96)
            {
                flame_18.SetActive(false);
                flame_19.SetActive(true);
                flame_20.SetActive(true);
                flame_light.range = 6;
                RenderSettings.fogEndDistance = 3.666f;

            }
            else if (player.GetTorchLife() == 80)
            {
                flame_19.SetActive(false);
                flame_20.SetActive(true);
                flame_21.SetActive(true);
                flame_light.range = 5;
                RenderSettings.fogEndDistance = 3.333f;

            }
            else if (player.GetTorchLife() == 64)
            {
                flame_20.SetActive(false);
                flame_21.SetActive(true);
                flame_22.SetActive(true);
                flame_light.range = 4;
                RenderSettings.fogEndDistance = 3f;

            }
            else if (player.GetTorchLife() == 48)
            {
                flame_21.SetActive(false);
                flame_22.SetActive(true);
                flame_23.SetActive(true);
                flame_light.range = 3;
                RenderSettings.fogEndDistance = 2.666f;

            }
            else if (player.GetTorchLife() == 32)
            {
                flame_22.SetActive(false);
                flame_23.SetActive(true);
                flame_24.SetActive(true);
                flame_light.range = 2;
                RenderSettings.fogEndDistance = 2.333f;

            }
            else if (player.GetTorchLife() == 16)
            {
                flame_23.SetActive(false);
                flame_24.SetActive(true);
                flame_25.SetActive(true);
                flame_light.range = 1;
                RenderSettings.fogEndDistance = 2f;

            }
            else if (player.GetTorchLife() == 0)
            {
                flame_24.SetActive(false);
                flame_25.SetActive(true);
                flame_26.SetActive(true);
                flame_light.range = 0;
                RenderSettings.fogEndDistance = 1.666f;
                StartCoroutine("torchOut");
            }
        } 
    }

    IEnumerator torchDim()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            player.DimmingofTorch();
        }
    }

    IEnumerator torchOut()
    {
        yield return new WaitForSeconds(16);
        flame_25.SetActive(false);
        flame_26.SetActive(false);
    }
}
