using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverChange : MonoBehaviour
{
    public Sprite[] staticList;
    public SpriteRenderer sp;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            sp.sprite = staticList[1]; 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            sp.sprite = staticList[0];
        }
    }
}
