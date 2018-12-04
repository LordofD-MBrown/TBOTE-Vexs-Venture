using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class MadnessAura : MonoBehaviour
{
    CameraShakeInstance cameraShake;
    GameObject playerCamera;
    float magnitude = 4f;
    float roughness = 4f;
    float fadeInTime = .1f;
    float fadeOutTime = 1f;



    /*void Start()
    {
        
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }*/

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER HAS ENTERED EVENT COLLIDER");
            
        }
        
    }
    IEnumerator OnTriggerStay(Collider other)
    {
        // While inside collider, periodically shake camera and increase its intensity
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player is still inside event collider");
            //StartCoroutine("MadnessEffect");
            //RenderSettings.fogEndDistance -= 1;
            CameraShaker.Instance.ShakeOnce(magnitude, roughness, fadeInTime, fadeOutTime);
            yield return new WaitForSeconds(1);
        }
    }
    

}
