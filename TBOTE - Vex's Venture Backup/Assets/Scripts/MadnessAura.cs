using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class MadnessAura : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("PLAYER HAS ENTERED EVENT COLLIDER");
            
        }
        
    }
    IEnumerator OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            RenderSettings.fogDensity += .0005f;
            
            yield return new WaitForSeconds(1);
        }
    }

    


}
