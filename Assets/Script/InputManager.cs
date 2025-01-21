using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public Button StartButton;


    void Start()
    {
        StartButton.onClick.AddListener(StartClick);
    }

    private void MoveAction()
    {
        
    }

    private void StartClick()
    {
        GameManager.Instance.SendMessage("StartGame");
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.IsGameStart) return;


        //input =  Vector2 Value from user input
        Vector2 input = new Vector2(0, 1);

        GameManager.Instance.SendMessage("MovePlayer", input);
    }
}
