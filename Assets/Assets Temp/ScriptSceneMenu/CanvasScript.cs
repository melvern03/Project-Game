using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    
    public GameObject CanvasMenu;
    public GameObject PanelAwal;
    public TextMeshProUGUI text;
    public GameObject btnPlay,btnExit;
    public AudioSource Music;
    public UnityEngine.Video.VideoPlayer vp;

     private void Start() {
        CanvasMenu.SetActive(true);
        PanelAwal.SetActive(true);
    }
    public void play()
    {
        text.enabled = false;
        btnExit.SetActive(false);
        btnPlay.SetActive(false);
        Music.Stop();
        vp.Play();
        StartCoroutine("waitVideo");
    }

    IEnumerator waitVideo()
    {
        yield return new WaitForSeconds(120f);
        SceneManager.LoadScene("Stage 1");
    }

    public void exitGame(){
        Application.Quit();
    }
}
