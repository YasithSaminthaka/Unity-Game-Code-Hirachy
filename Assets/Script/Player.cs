using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{  
    public void Attach()
    {

    }
    public void Move()
    {
        //move
    }
    void Dead()
    {
        GameManager.Instance.SendMessage("DeadAction");
    }
}
