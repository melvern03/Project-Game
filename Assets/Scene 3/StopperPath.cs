using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopperPath : MonoBehaviour
{
    public GameObject secret;
    public AudioSource sfx;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "KejarBoulder(Clone)")
        {
            other.GetComponent<Animator>().enabled = false;
            secret.SetActive(true);
            sfx.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
