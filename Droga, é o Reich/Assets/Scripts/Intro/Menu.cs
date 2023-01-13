using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public string cena;
    public GameObject creditos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void JOGAR()
    {
        SceneManager.LoadScene(1);
    }

    public void CREDITOS()
    {
        creditos.SetActive(true);
    }

    public void BACK()
    {
        creditos.SetActive(false);
    }
    public void SAIR()
    {
        // Editor Unity
        //UnityEditor.EditorApplication.isPlaying = false;

        // jogo Compilado
        Application.Quit();
    }

}
