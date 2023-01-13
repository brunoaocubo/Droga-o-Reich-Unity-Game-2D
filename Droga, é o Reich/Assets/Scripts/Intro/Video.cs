using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Video : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Videos());
    }

    // Update is called once per frame
    public void Pular()
    {
        SceneManager.LoadScene(3);
    }

    IEnumerator Videos()
    {
        yield return new WaitForSeconds(75);

        SceneManager.LoadScene(3);
    }
}
