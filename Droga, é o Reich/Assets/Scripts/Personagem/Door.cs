using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Transform posGo;
    private AudioSource audio;

    private bool playerDetected; // Variável para detectar se o player está tocando o objeto.
    GameObject playerGO; // Variável da qual o player irá se deslocar.


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
                playerGO.transform.position = posGo.position;
                playerDetected = false;
                audio.Play();
            }
        }
    }
     
    // O sistema básico de entrada de colisão com Trigger.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Nesta linha diz exatamente que se o objeto com a tag ''Player'' colidir com o objeto que irá ser usado, ative a variável de detecção.
        // 
        if (collision.CompareTag("Player"))
        {
            playerDetected = true;
            playerGO = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerDetected = false;
    }
}
