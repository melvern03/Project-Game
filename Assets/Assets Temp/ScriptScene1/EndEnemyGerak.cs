using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndEnemyGerak : MonoBehaviour
{
    public GameObject Enemies;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name=="karakter"){
            Enemies.GetComponent<EnemiesKejar>().targets="none";            
        }
         
    }
}
