using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovementManager : MonoBehaviour {
    public static MobileMovementManager instance;
    public bool up, down, left, right,tightn,untie;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void _up()
    {
        if (up)
            up = false;
        else
            up = true;
    }
    public void _down()
    {
        if (down)
            down = false;
        else
            down = true;
    }
    public void _left()
    {
        if (left)
            left = false;
        else
            left = true;
    }
    public void _right()
    {
        if (right)
            right = false;
        else
            right = true; 
    }
    public void _tightn()
    {
        if (tightn)
            tightn = false;
        else
            tightn = true;
    }
    public void _untie()
    {
        if (untie)
            untie = false;
        else
            untie = true;
    }
}
