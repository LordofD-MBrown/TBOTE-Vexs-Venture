using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDarkOneSpawn : MonoBehaviour {

    public GameObject TheDarkOne;

    public GameObject flame;
    public GameObject flame1;
    public GameObject flame2;
    public GameObject flame3;
    public GameObject flame4;
    public GameObject flame5;
    public GameObject flame6;
    public GameObject flame7;
    public GameObject flame8;
    public GameObject flame9;
    public GameObject flame10;
    public GameObject flame11;
    public GameObject flame12;
    public GameObject flame13;
    public GameObject flame14;
    public GameObject flame15;
    public GameObject flame16;
    public GameObject flame17;
    public GameObject flame18;
    public GameObject flame19;
    public GameObject flame20;
    public GameObject flame21;
    public GameObject flame22;
    public GameObject flame23;
    public GameObject flame24;
    public GameObject flame25;


    void Start ()
    {
        Time.timeScale = 1;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "Player")
        {
            StartCoroutine("SpawningofTheDarkOne");
        }
    }

    IEnumerator SpawningofTheDarkOne()
    {
        float waitTime = 2f;

        flame.SetActive(true);
        flame1.SetActive(true);
        TheDarkOne.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame2.SetActive(true);
        flame3.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame4.SetActive(true);
        flame5.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame6.SetActive(true);
        flame7.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame8.SetActive(true);
        flame9.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame10.SetActive(true);
        flame11.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame12.SetActive(true);
        flame13.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame14.SetActive(true);
        flame15.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame16.SetActive(true);
        flame17.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame18.SetActive(true);
        flame19.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame20.SetActive(true);
        flame21.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame22.SetActive(true);
        flame23.SetActive(true);
        yield return new WaitForSeconds(waitTime);

        flame24.SetActive(true);
        flame25.SetActive(true);
        yield return new WaitForSeconds(waitTime);
    }

}
