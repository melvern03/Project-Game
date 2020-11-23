using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public GameObject canvas_mc;
    bool sedanglompat;
    float delaylompat;
    public Vector3 lastcheckpoin;
    // Animator an;
    int jumpHeight=10;
    Rigidbody2D rb;
    float dx;
    Vector2 pos;
    Vector2 flip;Animator an;
    bool isfalling;
    // Start is called before the first frame update
    void Start()
    {
        // an=gameObject.GetComponent<Animator>();
        delaylompat=100f;
        sedanglompat=false;
        flip=transform.localScale;
        rb=gameObject.GetComponent<Rigidbody2D>(); 
        an=gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {        
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(flip.x>0)flip.x*=-1;            
            transform.localScale=flip;
            dx=-3;
             an.SetBool("SedangJalan",true);
            
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            if(flip.x<0)flip.x*=-1;
            
            transform.localScale=flip;
            dx=3;
             an.SetBool("SedangJalan",true);
        }
        if (Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D))
        {
            an.SetBool("SedangJalan",false);
            dx=0;
        }
        if(Input.GetKeyDown(KeyCode.Space) && sedanglompat==false){
            // gameObject.GetComponent<SoundEffect>().playSound(1,false,1f);
            sedanglompat=true;
            an.SetBool("sedangLompat",true);
            // transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
            // gameObject.GetComponent<Rigidbody2D>().velocity.y = jumpHeight;
            rb.AddForce(new Vector2(rb.velocity.x,8),ForceMode2D.Impulse);
        }
        rb.velocity = new Vector2(dx,rb.velocity.y);

    }
    private void FixedUpdate() {       
        if(rb.velocity.y<-0.1 && sedanglompat){
            an.SetBool("sedangLompat",true);
            isfalling=true;
        }
        else if(rb.velocity.y==0 && !sedanglompat)
        {            
            an.SetBool("sedangLompat",false);             
            isfalling=false;
        }
        if(rb.velocity.y==0 && sedanglompat){
            sedanglompat=false;
        }

    }
    // Start is called before the first frame update    
}
