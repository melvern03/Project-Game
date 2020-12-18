using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;
using UnityEngine.SceneManagement;

public class PindaScene : MonoBehaviour
{
    public TextMeshProUGUI textBawah;// Text Canvas
    public VideoPlayer vp;

    public GameObject Panel;

    public GameObject btn;
    public AudioSource Music;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "karakter")
        {
            Panel.SetActive(true);
            btn.SetActive(false);
            Music.Stop();
            vp.enabled = true;
            vp.Play();
            StartCoroutine("waitVideo");
        }
    }

    IEnumerator waitVideo()
    {
        yield return new WaitForSeconds(65f);
        SceneManager.LoadScene(3);
    }
}
