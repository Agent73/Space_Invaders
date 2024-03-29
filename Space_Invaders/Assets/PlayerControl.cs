﻿//PlayerControler.cs
//Created: 6/28/2019
//Owner: Siddharth 

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 respawn;
    public float speed;
    public static int lives;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        text = GetComponent<Text>();
        lives = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;


        if (Input.GetKey(KeyCode.D))
        {
           direction.x = speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -speed;
        }

        if (Input.GetKey(KeyCode.Space))
        {

        }
        rb.velocity = direction;

        if (text)
        {
            text.text = "Lives: " + lives.ToString();
        }
    }

    void Die()
    {
        GetComponent<AudioSource>().Play();
        Respawn();
        lives--;
        if (lives < 1)
        {
            SceneManager.LoadScene("DeathScreen");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyBullet2>())
        {
            Die();
        }
        else if (collision.gameObject.GetComponent<InvaderAI>())
        {
            Die();
        }
    }



    void Respawn()
    {
        
    }
}
