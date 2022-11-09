using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHead : MonoBehaviour
{
    public GameObject ninja;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shuriken")
        {
            Object.Destroy(ninja.gameObject);
            GameManager.Instance.HitHead();
        }
    }
}