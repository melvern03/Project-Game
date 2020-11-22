using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batasBawah : MonoBehaviour
{
    GameObject Karakter;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name=="karakter"){
            Karakter=GameObject.Find("karakter");        
            Karakter.transform.position=Karakter.GetComponent<Karakter>().lastcheckpoin;
        }

    }
}
