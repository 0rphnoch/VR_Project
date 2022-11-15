using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBody : MonoBehaviour
{
    public GameObject ninja;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Shuriken")
        {
            ninja.transform.position = SpawnEnemy.Instance.GetRandomPosition();
            GameManager.Instance.HitBody();
            AudioManager.Instance.PlaySFX("Hit");
        }
    }

}
