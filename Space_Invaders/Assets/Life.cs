using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Life : MonoBehaviour
{
    public static int lives;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (text)
        {
            text.text = "Lives: " + lives.ToString();
        };

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<EnemyBullet>())
        {
            lives--;

        }
    }
}
