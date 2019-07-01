//PlayerControler.cs
//Created: 6/28/2019
//Owner: Siddharth 

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 respawn;
    public float speed;
    int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<EnemyBullet>())
        {
            Respawn();
            lives--;
            if (lives < 1)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("TitleScreen");
            }
        }

    }

    private void Respawn()
    {
        throw new NotImplementedException();
    }
}
