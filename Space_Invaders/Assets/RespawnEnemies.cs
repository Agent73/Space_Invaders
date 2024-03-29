﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RespawnEnemies : MonoBehaviour
{
    Vector3 spawnpoint;
    //public GameObject copyPrefab;
    public delegate void RespawnDelegate();
    public UnityEvent runOnRespawn;
    public string prefabPath;
    public bool respawnWhenAllKilled = true;

    private void Start()
    {
        spawnpoint = transform.position;
    }
    public void Update()
    {
        if (transform.childCount == 0 && respawnWhenAllKilled)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        runOnRespawn.Invoke();

        //GameObject newCopy = Instantiate(copyPrefab, spawnpoint, Quaternion.Euler(0,0,0));
        Debug.Log("Respawning");
        GameObject newCopy = Instantiate(Resources.Load<GameObject>(prefabPath));
        Debug.Log("Setting position");
        newCopy.transform.position = spawnpoint;
        //newCopy.GetComponent<RespawnEnemies>().copyPrefab = copyPrefab;
        newCopy.GetComponent<RespawnEnemies>().runOnRespawn = runOnRespawn;
        Debug.Log("Destroying myself");
        Destroy(gameObject);
    }
}
