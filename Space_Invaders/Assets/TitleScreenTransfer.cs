//TitleScreenTransfer.cs
//Created: 6/28/2019
//Owner: Siddharth


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenTransfer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void ClickButton()
    {
        SceneManager.LoadScene("Environment");
    }
}
