//Shield.cs
//7-1-19
//OmarreeKimbrough
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<BulletLife>()
            || collision.transform.GetComponent<InvaderAI>())
        {
            Destroy(gameObject);
        }

    }
}
