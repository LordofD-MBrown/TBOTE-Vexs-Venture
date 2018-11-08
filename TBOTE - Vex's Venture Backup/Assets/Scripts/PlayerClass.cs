﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{

    private bool torch = true;
    private bool knife = false;
    private bool nightPotion = false;

    private int torchLife = 400;

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
    public int GetTorchLife()
    {
        return torchLife;
    }
    //===================================================

    public void DimmingofTorch()
    {
        torchLife--;
    }



        

}