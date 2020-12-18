using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Blocked : MonoBehaviour
{
    public TextMeshProUGUI text;
    int fadeInCheck;
    float fadeDelay;
    void Start()
    {
        fadeDelay = 150f;
        fadeInCheck = 0;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "karakter")
        {
            text.enabled = true;
            TextFade("Pintu Masih Tertutup carilah tuas untuk membuka pintu ini");
        }
    }
    public void TextFade(string nama)
    {
        text.SetText(nama);
        fadein();
    }
    void Update()
    {

        if (fadeInCheck == 3)
        {
            text.CrossFadeAlpha(0, 2, false);
            fadeInCheck = 1;
        }
    }
    public void fadein()
    {
        text.CrossFadeAlpha(1, 2, false);
        fadeInCheck = 2;
    }
    void FixedUpdate()
    {
        if (fadeInCheck == 2)
        {
            fadeDelay--;
            if (fadeDelay <= 0)
            {
                fadeDelay = 150f;
                fadeInCheck = 3;
            }
        }
    }
}
