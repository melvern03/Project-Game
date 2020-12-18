using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDown : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float WaitTime;
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            effector.rotationalOffset = 180f;
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyUp(KeyCode.S))
        {
            effector.rotationalOffset = 0f;
        }
    }
}
