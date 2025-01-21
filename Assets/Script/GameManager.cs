using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private Player player;

    [SerializeField]
    private InputManager inputManager;

    [SerializeField]
    private UIMAnager UIMAnager;

    PlayerBase playerController;

    private bool isGameStart = false;

    // Public getter with no setter
    public bool IsGameStart => isGameStart;

    void Start()
    {
        playerController = new PlayerController(player);
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameStart)
        {
            //logic
        }
    }

    public void StartGame()
    {
        isGameStart = true;
        UIMAnager.SendMessage("GameStart");
    }
    void DeadAction()
    {
        StopGame();
        UIMAnager.SendMessage("FinishGame");
    }
    public void StopGame()
    {
        isGameStart = false;
    }

    void MovePlayer(Vector2 value)
    {
        if(IsGameStart)
            playerController.Move(value);
    }
    
}
