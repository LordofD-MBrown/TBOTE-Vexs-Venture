using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerClass : MonoBehaviour
{

    private bool torch = false;
    private bool knife = false;
    private bool nightPotion = false;
    private bool inAnim = false;
    private bool tome = false;
    private bool escaped = false;
    private float duration_of_potion = 10f;

    private double torchLife = 400;

    //Setters===========================================
    public void SetTorch(bool t_torch)
    {
        torch = t_torch;
    }
    public void SetKnife(bool t_knife)
    {
        knife = t_knife;
    }
    public void SetNightPotion(bool t_nightPotion)
    {
        nightPotion = t_nightPotion;
    }
    public void SetTorchLife(int t_torchLife)
    {
        torchLife = t_torchLife;
    }
    public void SetInAnim(bool t_inAnim)
    {
        inAnim = t_inAnim;
    }
    public void SetTome(bool t_tome)
    {
        tome = t_tome;
    }
    public void SetEscaped(bool t_escape)
    {
        escaped = t_escape;
    }
    //===================================================

    
    //Getters============================================
    public bool GetTorch()
    {
        return torch;
    }
    public bool GetKnife()
    {
        return knife;
    }
    public bool GetNightPotion()
    {
        return nightPotion;
    }
    public double GetTorchLife()
    {
        return torchLife;
    }
    public bool GetInAnim()
    {
        return inAnim;
    }
    public bool GetTome()
    {
        return tome;
    }
    public bool GetEscaped()
    {
        return escaped;
    }
    //===================================================

    public void DimmingofTorch()
    {
        torchLife--;
        if(torchLife < 0)
        {
            torchLife = 0;
        }
    }

    public void GrabPotion()
    {
        nightPotion = true;
        duration_of_potion += 10f;
    }

    public void usePotion()
    {
        StartCoroutine("PotionLength");  
    }

    IEnumerator PotionLength()
    {
        nightPotion = false;
        RenderSettings.fog = false;
        yield return new WaitForSeconds(duration_of_potion);
        RenderSettings.fog = true;
    }



        

}
