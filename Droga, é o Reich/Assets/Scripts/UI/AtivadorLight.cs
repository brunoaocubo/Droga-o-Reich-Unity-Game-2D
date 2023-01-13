using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivadorLight : MonoBehaviour
{
    [SerializeField]
    private bool Personagem;
    public GameObject Luz;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Nesta linha diz exatamente que se o objeto com a tag ''Player'' colidir com o objeto que irá ser usado, ative a variável de detecção.

       if (collision.CompareTag("Player"))
       {
           Luz.SetActive(true);
           Personagem = false;
       }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
