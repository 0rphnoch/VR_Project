using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public static SpawnEnemy Instance;

    void Awake()
    {
        Instance = this;
    }

    [SerializeField] BoxCollider col;

    public Vector3 GetRandomPosition()
    {
        Vector3 center = col.center + transform.position;

        float minX = center.x - col.size.x / 2f;
        float maxX = center.x + col.size.x / 2f;

        float minZ = center.z - col.size.z / 2f;
        float maxZ = center.z + col.size.z / 2f;

        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);

        Vector3 randomPosition = new Vector3(randomX, 0f, randomZ);

        return randomPosition;
    }

}
