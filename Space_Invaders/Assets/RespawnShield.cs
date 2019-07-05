using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RespawnShield : MonoBehaviour
{
    Vector3 spawnpoint;
    //public GameObject copyPrefab;
    public string prefabPath;

    private void Start()
    {
        spawnpoint = transform.position;
        if (prefabPath == "")
            prefabPath = gameObject.name;
    }

    public void Respawn()
    {
        //GameObject newCopy = Instantiate(copyPrefab, spawnpoint, Quaternion.Euler(0,0,0));
        Debug.Log("Respawning Shield");
        GameObject newCopy = Instantiate(Resources.Load<GameObject>(prefabPath));
        Debug.Log("Setting position");
        newCopy.transform.position = spawnpoint;
        Debug.Log("Clearing children");
        foreach (Transform c in transform)
        {
            c.parent = null;
            GameObject.Destroy(c.gameObject);
        }
        Debug.Log("Child count: " + transform.childCount);
        Debug.Log("Stealing children");
        while (newCopy.transform.childCount > 0)
        {
            newCopy.transform.GetChild(0).parent = transform;
        }
        Debug.Log("Child count: " + transform.childCount);
        Destroy(newCopy);
    }
}