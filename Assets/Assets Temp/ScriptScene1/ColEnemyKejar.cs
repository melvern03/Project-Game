﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColEnemyKejar : MonoBehaviour
{
    public GameObject Enemies;
    public TextMeshProUGUI textBawah;// Text Canvas
    int fadeInCheck;
    float fadeDelay;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name=="karakter"){
            textBawah.enabled=true;
            TextFade("Awas Musuh Didepan bisa mengejarmu !");
            Enemies.GetComponent<EnemiesKejar>().targets="karakter";
            Enemies.GetComponent<EnemiesKejar>().speed=2;  
       }
    }
    private void OnTriggerExit2D(Collider2D other) {
         if(other.name=="karakter"){
            Enemies.GetComponent<EnemiesKejar>().targets="none";        
            Enemies.GetComponent<EnemiesKejar>().speed=5;            
        }
    }
    void Start()
    {
       
        fadeDelay = 100f;
        fadeInCheck = 0;
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
        textBawah.CrossFadeAlpha(1, 2, false);
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
                fadeDelay = 100f;
                fadeInCheck = 3;
            }
        }
    }
}
