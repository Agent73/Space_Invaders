using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet2 : MonoBehaviour
{
    float lifetime = 5;
    Rigidbody rb;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime < 0)
            Destroy(gameObject);
        rb.velocity = Vector3.down * speed;

    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (collision.transform.GetComponent<PlayerControl>()
            || collision.transform.GetComponent<Shields>())
        {
            Destroy(gameObject);
        }
    }
}
