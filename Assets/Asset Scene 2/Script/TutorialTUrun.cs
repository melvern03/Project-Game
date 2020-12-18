using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialTUrun : MonoBehaviour
{
    public TextMeshProUGUI text;
    bool first;
    int fadeInCheck;
    float fadeDelay;
    void Start()
    {
        first = false;
        fadeDelay = 150f;
        fadeInCheck = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter" && first == false)
        {
            first = true;
            text.enabled = true;
            TextFade("Tekan \"S\" pada keyboard untuk turun pada plaform tertentu");
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
            text.CrossFadeAlpha(0, 2, false);//Untuk Hilang no, 0 disini sebagai alpha / opacity
            //Param 1 opacity / alpha
            //Param 2 Waktu
            fadeInCheck = 1;
        }
    }
    public void fadein()
    {
        text.CrossFadeAlpha(1, 2, false);
        fadeInCheck = 2;
    }
    //Fade In Check 1 = mennunggu
    //Fade In Check 2 = mennampilkan
    //Fade In Check 3 = fadeout / selesai
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
