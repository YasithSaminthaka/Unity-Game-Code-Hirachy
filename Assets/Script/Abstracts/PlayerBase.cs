using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  PlayerBase : MonoBehaviour
{
    public float Health { get; protected set; }
    public float MaxHealth { get; protected set; }
    public bool IsAlive => Health > 0;
    public abstract void Move(Vector2 input);
    public abstract void Jump();
    public abstract void Attack();

    internal void Move(Vector2 vector2, object input)
    {
        throw new NotImplementedException();
    }
}
