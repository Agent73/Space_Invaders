﻿//Respawn.cs
//7-1-19
//OmarreeKimbrough
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 respawn;
    int lives = 73;

    public void Update()
    {
        if (transform.childCount == 0)
        {
            Fox();
        }
    }
    public void Fox()
    {
        transform.position = respawn;
    }
}
