using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Intro : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Intros());
    }
    IEnumerator Intros()
    {
        
        yield return new WaitForSeconds(6);

        SceneManager.LoadScene(1);
        
    }
}
