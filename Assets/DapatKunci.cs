using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DapatKunci : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textBawah;
    int fadeInCheck;
    float fadeDelay;
    void Start()
    {
        fadeDelay = 150f;
        fadeInCheck = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            textBawah.enabled = true;
            TextFade("Anda Mendapatkan Kunci");
            gameObject.SetActive(false);
        }
    }
    public void TextFade(string nama)
    {
        textBawah.SetText(nama);
        fadein();
    }
    void Update()
    {
        if (fadeInCheck == 3)
        {
            textBawah.CrossFadeAlpha(0, 2, false);
            fadeInCheck = 1;
        }
    }
    public void fadein()
    {
        textBawah.CrossFadeAlpha(1, 3, false);
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
