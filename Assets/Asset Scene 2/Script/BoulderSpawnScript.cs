using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSpawnScript : MonoBehaviour
{
    Vector3 position;
    public GameObject Trigger;
    public GameObject boulder;
    void Start()
    {
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "karakter")
        {
            position = col.transform.position;
            if (position.x -  Trigger.transform.position.x < 0)
            {
                Vector3 pos = new Vector3(-1.092203f, -4.974573f);
                Instantiate(boulder,pos,Quaternion.identity);
            }
            
        }
    }
    void Update()
    {
        
    }
}
