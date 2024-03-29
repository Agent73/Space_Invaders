﻿//BlinkingAnimation.cs
//Created: 6/28/2019
//Owner: SIddharth

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingAnimation : MonoBehaviour
{
    Text bl;
    float timeUntilChange;
    public float secondsPerFrame;

    // Start is called before the first frame update
    void Start()
    {
        bl = GetComponent<Text>();
        timeUntilChange = secondsPerFrame;
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilChange -= Time.deltaTime;
        if (timeUntilChange <= 0)
        {
            timeUntilChange = secondsPerFrame;

            if (bl.enabled == false)
            {
                bl.enabled = true;
            }
            else
            {
                bl.enabled = false;
            }
        }
    }
}