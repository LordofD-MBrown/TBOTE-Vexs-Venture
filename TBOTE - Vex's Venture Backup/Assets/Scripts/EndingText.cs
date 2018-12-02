using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndingText : MonoBehaviour {

    public GameObject textBox;
    GameObject player;
    TextMeshProUGUI endingText;
    
    bool active = false;
    bool ended = false;
    int text = 0;

	void Start ()
    {
        player = GameObject.Find("Player");
        endingText = textBox.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if(text == 0)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, endingText));
            }         
        }
        else if (text == 1)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, endingText));
            }           
        }
        else if(text == 2)
        {
            endingText.SetText("However...");
            text++;
        }
        if (text == 3)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, endingText));
            }
        }
        else if (text == 4)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, endingText));
            }
        }
        else if (text == 5)
        {
            endingText.SetText("The Book is Too Damaged to be Read...");
            text++;
        }
        if (text == 6)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, endingText));
            }
        }
        else if (text == 7)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, endingText));
            }
        }
        else if (text == 8)
        {
            endingText.SetText("Thus... WORTHLESS");
            text++;
        }
        if (text == 9)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, endingText));
            }
        }
        else if (text == 10)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, endingText));
            }
        }
        else if (text == 11)
        {
            endingText.SetText("But, You Vanquished the Evil of this Land");
            text++;
        }
        if (text == 12)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, endingText));
            }
        }
        else if (text == 13)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, endingText));
            }
        }
        else if (text == 14)
        {
            endingText.SetText("GAME OVER");
            text++;
        }
        if (text == 15)
        {
            if (ended == true)
            {
                text++;
                ended = false;
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToFullAlpha(1f, endingText));
            }
        }
        else if (text == 16)
        {
            if (ended == true)
            {
                text++;
                ended = false;
                Cursor.lockState = CursorLockMode.None;
                player.SetActive(false);
                SceneManager.LoadScene(0);
            }
            else if (!active)
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, endingText));
            }
        }
    }

    public IEnumerator FadeTextToFullAlpha(float t, TextMeshProUGUI i)
    {
        
        active = true;
        yield return new WaitForSeconds(1);
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        active = false;
        ended = true;
    }
    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        active = true;
        yield return new WaitForSeconds(5);
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
        active = false;
        ended = true;
    }

    /*
    public IEnumerator Ending()
    {
        /*float time = 5;
        endingText.SetText("You Escaped...");
        yield return new WaitForSeconds(time);
        //StartCoroutine(FadeTextToFullAlpha(1f, endingText));
        endingText.color = new Color(endingText.color.r, endingText.color.g, endingText.color.b, 0);
        while (endingText.color.a < 1.0f)
        {
            endingText.color = new Color(endingText.color.r, endingText.color.g, endingText.color.b, endingText.color.a + (Time.deltaTime / 1f));
            yield return null;
        }
        yield return new WaitForSeconds(time + 2);
        //StartCoroutine(FadeTextToZeroAlpha(1f, endingText));
        endingText.color = new Color(endingText.color.r, endingText.color.g, endingText.color.b, 1);
        while (endingText.color.a > 0.0f)
        {
            endingText.color = new Color(endingText.color.r, endingText.color.g, endingText.color.b, endingText.color.a + (Time.deltaTime / 1f));
            yield return null;
        }
        yield return new WaitForSeconds(time);
        
    }
    */
}
