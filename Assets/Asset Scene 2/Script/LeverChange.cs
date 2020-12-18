using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeverChange : MonoBehaviour
{
    public Sprite[] staticList;
    public SpriteRenderer sp;
    public TextMeshProUGUI text;

    public GameObject secret;
    public GameObject pillar;
    public GameObject FakeFloor;

    public AudioSource sfx;

    bool cek;
    int fadeInCheck;
    float fadeDelay;
    void Start()
    {
        fadeDelay = 150f;
        fadeInCheck = 0;
        cek = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            if (sp.sprite.name == "leverV2_3")
            {
                text.enabled = true;
                text.SetText("Tekan \"E\" pada keyboard untuk menarik tuas");
                cek = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            text.enabled = false;
            cek = false;
        }
    }

    void Update()
    {
        if (cek)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                sp.sprite = staticList[1];
                sp.transform.position = new Vector3(39.447f, -43.425f);
                text.enabled = true;
                TextFade("Pintu Berhasil Dibuka");
                secret.SetActive(true);
                FakeFloor.SetActive(false);
                pillar.SetActive(false);
                sfx.Play();
            }
        }

        if (fadeInCheck == 3)
        {
            text.CrossFadeAlpha(0, 2, false);
            fadeInCheck = 1;
        }
    }
    public void TextFade(string nama)
    {
        text.SetText(nama);
        fadein();
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
