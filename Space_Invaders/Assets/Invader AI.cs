//InvaderAL.cs
//6-28-19
//OmarreeKimbrough
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderAI : MonoBehaviour
{
    Rigidbody rb;
    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }
    private void OnDrawGizmos()
    {
        if(rb)
            Gizmos.DrawLine(transform.position, transform.position + rb.velocity); 
    }
}
