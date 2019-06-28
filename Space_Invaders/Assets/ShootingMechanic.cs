using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMechanic : MonoBehaviour
{

    public GameObject bullet;

    public KeyCode fire = KeyCode.Space;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fire))
        {
            GameObject newBullet = Instantiate

        }
        
    }
}
