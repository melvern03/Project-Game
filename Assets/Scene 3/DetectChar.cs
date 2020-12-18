using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectChar : MonoBehaviour
{
    bool moving;
    Vector3 lastPos;
    GameObject detect;
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "karakter")
        {
            var displacement = transform.position - lastPos;
            lastPos = transform.position;
            if (displacement.magnitude > 0.001)  // return true if char moved 1mm
            {
                moving = true;
            }
            else
            {
                moving = false;
            }
            if (moving)//Mati
            {
                detect = GameObject.Find("DetectorKejar");
                detect.GetComponent<boulderspawn>().cek = false;
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
