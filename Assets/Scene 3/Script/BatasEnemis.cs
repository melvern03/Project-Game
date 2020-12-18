using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatasEnemis : MonoBehaviour
{
    public GameObject enemies;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("enemies"))
        {
            if (enemies.GetComponent<EnemiesGerak>().gerak == "kiri") enemies.GetComponent<EnemiesGerak>().gerak = "kanan";
            else { enemies.GetComponent<EnemiesGerak>().gerak = "kiri"; }
        }

    }
}
