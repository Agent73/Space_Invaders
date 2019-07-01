//EnemyAI
//7-1-19
//OmarreeKimbrough
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 1;
    public float FramesPerSecond;
    float timeUntilChange;
    float SecondsPerFrame;
    bool movedDown;

    void Start()
    {
        UpdateFramesPerSecond();
        timeUntilChange = SecondsPerFrame;
        
    }

    void Move()
    {
        transform.localPosition += Vector3.right * speed;
    }

    void Update()
    {
        UpdateFramesPerSecond();
        timeUntilChange -= Time.deltaTime;
        if (FramesPerSecond > 0 && timeUntilChange < 0)
        {
            Move();
            timeUntilChange = SecondsPerFrame;
        }
        movedDown = false;
    }
    void UpdateFramesPerSecond()
    {
        if (FramesPerSecond == 0)
            FramesPerSecond = 0.0001f;
        SecondsPerFrame = 1f / FramesPerSecond;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyTrigger>() && !movedDown)
        {
            movedDown = true;
            speed *= -1;
            Move();
            transform.position += Vector3.down * 1;
        }
    }
}
