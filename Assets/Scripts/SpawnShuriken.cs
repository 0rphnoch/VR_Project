using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShuriken : MonoBehaviour
{
    [SerializeField] private GameObject shuriken;

    [SerializeField] private Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (shuriken.transform.position.y < -2f)
        {
            shuriken.transform.position = spawnPoint.position;
            shuriken.transform.rotation = spawnPoint.rotation;
        }
    }
}
