//MyAnimation.cs
//6-28-19
//OmarreeKimbrough
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnimation : MonoBehaviour
{
    public Sprite[] sprites;
    int currentsprite = 0;
    public float FramesPerSecond;
    float SecondsPerFrame;
    float timeUntilChange;

    void UpdateFramesPerSecond()
    {
        if (FramesPerSecond == 0)
            FramesPerSecond = 0.0001f;
        SecondsPerFrame = 1f / FramesPerSecond;
    }


    void Start()
    {
        UpdateFramesPerSecond();
        timeUntilChange = SecondsPerFrame;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFramesPerSecond();
        GetComponent<SpriteRenderer>().sprite = sprites[currentsprite];
        timeUntilChange -= Time.deltaTime;
        if (FramesPerSecond > 0 && timeUntilChange < 0)
        {
            timeUntilChange = SecondsPerFrame;
            currentsprite++;
            if (currentsprite >= sprites.Length)
                currentsprite = 0;
        }
        else if (FramesPerSecond < 0 && timeUntilChange < 0)
        {
            timeUntilChange = -SecondsPerFrame;
            currentsprite--;
            if (currentsprite < 0)
                currentsprite = sprites.Length - 1;
        }
       
    }
}
