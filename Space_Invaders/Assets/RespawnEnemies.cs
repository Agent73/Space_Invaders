using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemies : MonoBehaviour
{
    Vector3 spawnpoint;
    //public GameObject copyPrefab;

    private void Start()
    {
        spawnpoint = transform.position;
    }
    public void Update()
    {
        if (transform.childCount == 0)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        //GameObject newCopy = Instantiate(copyPrefab, spawnpoint, Quaternion.Euler(0,0,0));
        Debug.Log("Respawning");
        GameObject newCopy = Instantiate(Resources.Load<GameObject>("Enemies"));
        Debug.Log("Setting position");
        newCopy.transform.position = spawnpoint;
        //newCopy.GetComponent<RespawnEnemies>().copyPrefab = copyPrefab;
        Debug.Log("Destroying myself");
        Destroy(gameObject);
    }
}
