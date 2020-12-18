using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;
using UnityEngine.SceneManagement;

public class lastPindah : MonoBehaviour
{
    public TextMeshProUGUI textBawah;// Text Canvas
    public VideoPlayer vp;

    public GameObject Panel;

    public GameObject btn;
    public AudioSource Music;
    int fadeInCheck;
    float fadeDelay;

    public GameObject kunci;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter" && !kunci.activeSelf)
        {
            Panel.SetActive(true);
            btn.SetActive(false);
            Music.Stop();
            vp.enabled = true;
            vp.Play();
            StartCoroutine("waitVideo");
        }
        else
        {
            textBawah.enabled = true;
            TextFade("Carilah kunci untuk membuka pintu ini");
        }
    }

    IEnumerator waitVideo()
    {
        yield return new WaitForSeconds(95f);
        SceneManager.LoadScene(0);
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

        if (fadeInCheck == 3)
        {
            textBawah.CrossFadeAlpha(0, 2, false);
            fadeInCheck = 1;
        }
    }
    public void fadein()
    {
        textBawah.CrossFadeAlpha(1, 2, false);
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
