using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VideoFinal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(VideosF());
    }

    // Update is called once per frame
    public void Inicio()
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator VideosF()
    {
        yield return new WaitForSeconds(40);

        SceneManager.LoadScene(1);
    }
}
