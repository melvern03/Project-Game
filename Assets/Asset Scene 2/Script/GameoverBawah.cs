using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverBawah : MonoBehaviour
{
    GameObject Karakter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            Karakter = GameObject.Find("karakter");
            Karakter.transform.position = Karakter.GetComponent<KarakterNew>().lastcheckpoin;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
