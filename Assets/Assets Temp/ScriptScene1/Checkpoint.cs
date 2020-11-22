using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    GameObject karakter;
    // Start is called before the first frame update
    void Start()
    {
        karakter=GameObject.Find("karakter");        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name=="karakter");
        karakter.GetComponent<Karakter>().lastcheckpoin=gameObject.transform.position;
    }


    
}
