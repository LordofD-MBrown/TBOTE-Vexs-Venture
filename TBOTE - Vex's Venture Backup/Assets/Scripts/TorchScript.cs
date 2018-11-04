using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour {

    public GameObject torch;

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

    public int Diming_Rate = 200;

    void Start()
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
    StartCoroutine("torchDim");
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update ()
    {
        if(Diming_Rate == 200)
        {
            flame_0.SetActive(true);
            flame_1.SetActive(false);
        }
        else if (Diming_Rate == 192)
        {
            flame_0.SetActive(false);
            flame_1.SetActive(true);
        }
        else if (Diming_Rate == 184)
        {
            flame_1.SetActive(false);
            flame_2.SetActive(true);
        }
        else if (Diming_Rate == 176)
        {
            flame_2.SetActive(false);
            flame_3.SetActive(true);
        }
        else if (Diming_Rate == 168)
        {
            flame_3.SetActive(false);
            flame_4.SetActive(true);
        }
        else if (Diming_Rate == 160)
        {
            flame_4.SetActive(false);
            flame_5.SetActive(true);
        }
        else if (Diming_Rate == 152)
        {
            flame_5.SetActive(false);
            flame_6.SetActive(true);
        }
    }

    IEnumerator torchDim()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            Diming_Rate--;
        }
    }
}
