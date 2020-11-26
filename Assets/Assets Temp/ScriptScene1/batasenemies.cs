using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batasenemies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemies;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name=="enemies"){
            if(enemies.GetComponent<Enemies>().gerak=="kiri")enemies.GetComponent<Enemies>().gerak="kanan";
            else{enemies.GetComponent<Enemies>().gerak="kiri";}
        }
        
    }
        
    
}
