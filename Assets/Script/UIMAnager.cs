using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMAnager : MonoBehaviour
{
    public Text StartText;
   

    void GameStart()
    {
        StartText.text = "Start";
    }
    void FinishGame()
    {
        StartText.text = "Dead!";
    }
}
