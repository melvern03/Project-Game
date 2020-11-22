using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CanvasSetting : MonoBehaviour
{
    
    public TextMeshProUGUI textBawah;    
    // public GameObject panel_bawah;
    
    int fadeInCheck;
    float fadeDelay;
    
    void Start()
    {
       

        fadeDelay = 150f;
        fadeInCheck = 0;
        TextFade("Tekan \"A\" pada keyboard untuk gerak kekiri dan Tekan \"D\" pada keyboard untuk gerak kekanan");
    }

    public void TextFade(string nama)
    { 
        textBawah.SetText(nama);
        fadein();
    }
    void Update()
    {        
        if (fadeInCheck==3)
        {
            textBawah.CrossFadeAlpha(0, 2, false);//Untuk Hilang no, 0 disini sebagai alpha / opacity
            //Param 1 opacity / alpha
            //Param 2 Waktu
            fadeInCheck = 1;
        }
    }
    public void fadein()
    {
        textBawah.CrossFadeAlpha(1, 3, false);
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
        if(fadeInCheck==1){

        }
    }

    
}
