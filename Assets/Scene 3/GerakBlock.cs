using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakBlock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "karakter")
        {
            collision.gameObject.transform.parent = transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "karakter")
        {
            collision.gameObject.transform.parent = null;
        }
    }
}
