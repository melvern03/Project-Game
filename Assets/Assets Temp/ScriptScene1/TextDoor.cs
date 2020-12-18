using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class TextDoor : MonoBehaviour
{
    public TextMeshProUGUI textBawah;// Text Canvas
    public VideoPlayer vp;

    public GameObject btn;
    public AudioSource Music;
    public GameObject panel;
    int fadeInCheck;
    float fadeDelay;
    // public GameObject panelbawah;
    
   
   private void OnTriggerEnter2D(Collider2D other) {
       if(other.name=="karakter"){
            btn.SetActive(false);
            Music.Stop();
            panel.SetActive(true);
            vp.enabled = true;
            vp.Play();
            StartCoroutine("waitVideo");
        }
    }
    IEnumerator waitVideo()
    {
        yield return new WaitForSeconds(75f);
        SceneManager.LoadScene(2);
    }
    void Start()
    {
        fadeDelay = 150f;
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
                fadeDelay = 150f;
                fadeInCheck = 3;
            }
        }
    }
}
