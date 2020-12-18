using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasScene3 : MonoBehaviour
{
    public TextMeshProUGUI textBawah;
    public GameObject Obj;
    public Vector3[] listVector3;
    void Start()
    {
        textBawah.enabled = false;
        StartSpawn();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartSpawn()
    {
        StartCoroutine("SpawnObj");
    }

    IEnumerator SpawnObj()
    {
        int pil = Random.Range(1, 4);
        Instantiate(Obj, listVector3[pil],Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(0.7f, 1.7f));
        StartCoroutine("SpawnObj");

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
