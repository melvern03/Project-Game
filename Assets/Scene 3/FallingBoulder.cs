using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBoulder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            other.gameObject.transform.position = other.gameObject.GetComponent<KarakterNew>().lastcheckpoin;
        }

        if (other.name == "DeletePrefab")
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
