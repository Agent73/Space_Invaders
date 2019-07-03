using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DPlogo : MonoBehaviour
{
    public const float TIME_LIMIT = 3F;
    private float timer = 0F;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.timer += Time.deltaTime;
        if (this.timer >= TIME_LIMIT)
        {
            SceneManager.LoadScene("Logo SplashScreen");
        }
    }

}
