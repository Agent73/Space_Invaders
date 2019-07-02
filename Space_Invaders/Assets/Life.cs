using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Life : MonoBehaviour
{
    public Text text;

    // Update is called once per frame
    void Update()
    {
        if (text)
        {
            text.text = "Lives: " + PlayerControl.lives.ToString();
        }
    }
}
