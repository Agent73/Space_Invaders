//player2.cs
//6-28-19
//OmarreeKimbrough
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode jump = KeyCode.W;
    public float speed = 5;
    public float jumpspeed = 5;
    Rigidbody rb;
    public Vector3 respawn;
int lives = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        respawn = transform.position;

    }
    public void Respawn()
    {
        transform.position = respawn;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<EnemyAI>() 
		|| collision.gameObject.tag == "DeadlyWalls")
        {
Respawn();
lives--;
if(lives < 1){
            Destroy(gameObject);
}
        }

    }


    // Update is called once per frame
    void Update()
    {
        
        Vector3 newVel = rb.velocity;
        if (Input.GetKey(left))
        {
            newVel.x = -speed;
        }
        if (Input.GetKey(right))
        {
            newVel.x = speed;
        }
        if (Input.GetKeyDown(jump))
        {
            newVel.y = jumpspeed;
        }
        rb.velocity = newVel;
    }

    private void OnDrawGizmos()
    {
        if (rb)
            Gizmos.DrawLine(transform.position, transform.position + rb.velocity);
    }

}
