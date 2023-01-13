using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjFinal : MonoBehaviour
{
    private AudioSource audio;
    private bool playerDetected; // Variável para detectar se o player está tocando o objeto.

    void Start()
    {
        playerDetected = false;
        audio = gameObject.GetComponent<AudioSource>();
    }

    void Update() 
    {
    // Adicionando um Input (Acionador / Gatilho) através da tecla 'E'.
        if (playerDetected)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(5);
                audio.Play();
                playerDetected = false;
                
            }
        }
    }

    // O sistema básico de entrada de colisão com Trigger.
    private void OnTriggerEnter2D(Collider2D collision)
    {
    // Nesta linha diz exatamente que se o objeto com a tag ''Player'' colidir com o objeto que irá ser usado, ative a variável de detecção.
    
        if (collision.CompareTag("Player"))
        {
            playerDetected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerDetected = false;
    }
}
