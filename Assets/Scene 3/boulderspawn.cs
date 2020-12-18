using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulderspawn : MonoBehaviour
{
    public GameObject Boulder;
    public bool cek;
    void Start()
    {
        cek = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter" && !cek)
        {
            Instantiate(Boulder,new Vector3(-62.6f, 7.17f), Quaternion.identity);
            cek = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
