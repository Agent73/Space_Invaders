//InvaderAL.cs
//6-28-19
//OmarreeKimbrough
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderAI : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision enter");
        if (collision.collider.GetComponent<BulletLife>())
        {
            Score.AddScore(100);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.parent.SendMessageUpwards("OnTriggerEnter", other);
    }
}
