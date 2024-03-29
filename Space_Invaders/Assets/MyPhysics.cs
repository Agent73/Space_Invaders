﻿//MyPhysics.cs
//6-28-19
//OmarreeKimbrough
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPhysics : MonoBehaviour
{
    public Vector2 velocity;
    public Vector2 acceleration;
    Vector2 gravity = new Vector2(0, -1); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity += Time.deltaTime * (acceleration + gravity);
        Vector3 p = transform.position;
        p.x += Time.deltaTime * velocity.x;
        p.y += Time.deltaTime * velocity.y;
        transform.position = p;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int count = 0;
        Vector2 sum = new Vector2(0, 0);
        while (count < collision.contactCount)
        {
            sum += collision.contacts[count].point;
            count += 1;
        }
        Vector2 average = sum / count;
        Vector2 position = new Vector2(transform.position.x, transform.position.y);
        Vector2 collisionPoint = average - position;
        if (Mathf.Abs(collisionPoint.x) > Mathf.Abs(collisionPoint.y))
        {
            velocity.x *= -1;
        }
        else
        {
            velocity.y *= -1;
        }
           
    }   

}
