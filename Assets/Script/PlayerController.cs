using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController :PlayerBase
{
    private Player player;

    public PlayerController(Player player)
    {
        this.player = player;
    }

    public override void Attack()
    {
        //logic

        player.Attach();
    }

    public override void Jump()
    {

    }

    public override void Move(Vector2 input)
    {
        player.Move();
    }

}
