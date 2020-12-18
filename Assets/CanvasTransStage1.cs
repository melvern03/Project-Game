using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasTransStage1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("waitVideo");
    }


    IEnumerator waitVideo()
    {
        yield return new WaitForSeconds(110f);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
