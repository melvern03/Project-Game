using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    GameObject Karakter;
    float dx;
    Vector2 pos;
    Vector2 flip;
    Rigidbody2D rb;
    public string gerak="kiri";

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name=="karakter"){
            Karakter=GameObject.Find("karakter");        
            Karakter.transform.position=Karakter.GetComponent<Karakter>().lastcheckpoin;
        }
    }
    private void Start() {
        flip=transform.localScale;
        rb=gameObject.GetComponent<Rigidbody2D>(); 
    }
    private void Update() {
        if(gerak=="kiri")
        {
            if(flip.x<0)flip.x*=-1;            
            transform.localScale=flip;
            dx=-4;            
        }
        if(gerak=="kanan")
        {
            if(flip.x>0)flip.x*=-1;
            
            transform.localScale=flip;
            dx=4;
        }
        rb.velocity = new Vector2(dx,rb.velocity.y);
    }
}
