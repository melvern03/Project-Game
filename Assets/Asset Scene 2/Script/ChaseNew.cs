using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseNew : MonoBehaviour
{
    public float speed = 2;
    public GameObject Karakter;
    public GameObject EnemyGerakAwal;
    public Vector3 target;
    public string targets = "";
    Vector2 flip;

    void Start()
    {
        Karakter = GameObject.Find("karakter");
        EnemyGerakAwal = GameObject.Find("StartEnery");
        target = EnemyGerakAwal.transform.position;
        flip = transform.localScale;
        targets = "none";

    }

    // Update is called once per frame
    void Update()
    {
        if (target.x > transform.position.x)
        {
            if (transform.localScale.x >= 1)
            {
                if (flip.x >= 1)
                {
                    flip.x *= -1;
                }

            }
        }
        else
        {
            if (transform.localScale.x < 1)
            {
                if (flip.x <= 1)
                {
                    flip.x *= -1;
                }
            }
        }
        transform.localScale = flip;
        if (targets == "none") target = EnemyGerakAwal.transform.position;
        else target = Karakter.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            Karakter = GameObject.Find("karakter");
            Karakter.transform.position = Karakter.GetComponent<KarakterNew>().lastcheckpoin;
        }
    }
}
