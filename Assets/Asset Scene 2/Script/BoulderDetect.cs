using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderDetect : MonoBehaviour
{
    bool moving;
    Vector3 lastPos;
    GameObject Karakter;
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "karakter")
        {
            var displacement = transform.position - lastPos;
            lastPos = transform.position;
            if (lastPos == transform.position)
            {

            }
            else if (displacement.magnitude > 0.001)  // return true if char moved 1mm
            {
                moving = true;
            }
            else
            {
                moving = false;
            }
            if (moving)
            {
                other.gameObject.transform.position = other.gameObject.GetComponent<KarakterNew>().lastcheckpoin;
                Destroy(gameObject);
            }
        }
    }
    
    void Update()
    {
        lastPos = transform.position;
    }
}
