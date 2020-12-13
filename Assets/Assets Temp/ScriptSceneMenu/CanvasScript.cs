using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{
    
    public GameObject CanvasMenu;
    public GameObject PanelAwal;

     private void Start() {
        CanvasMenu.SetActive(true);
        PanelAwal.SetActive(true);
    }
    public void play(){
        Debug.Log("Masuk");
        SceneManager.LoadScene("Stage 1");
    }
    public void exitGame(){
        Application.Quit();
    }
}
