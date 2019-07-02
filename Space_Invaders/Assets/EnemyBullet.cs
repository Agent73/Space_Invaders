//EnemyBullet.cs
//6-28-19
//OmarreeKimbrough
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject bullet;
    float lifetime = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        float x = 100 * 60;
        float y = 50;
        if ((!Physics.Raycast(transform.position, Vector3.down, out hit) 
            || hit.transform.tag != "Enemy") && Random.Range(0,x) < y)
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = transform.position + Vector3.down * transform.localScale.y * .5f;
            GetComponent<AudioSource>().Play();
        }
    }
    
}

