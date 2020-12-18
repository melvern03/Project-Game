using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColArea : MonoBehaviour
{
    public GameObject Enemies;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            Enemies.GetComponent<ChaseNew>().targets = "karakter";
            Enemies.GetComponent<ChaseNew>().speed = 2;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            Enemies.GetComponent<ChaseNew>().targets = "none";
            Enemies.GetComponent<ChaseNew>().speed = 5;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
