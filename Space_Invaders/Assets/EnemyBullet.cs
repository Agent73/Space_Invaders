using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Gameobject bullet;
    public KeyCode fire = KeyCode.space;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fire))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = transform.position;
        }
       
    }
}
