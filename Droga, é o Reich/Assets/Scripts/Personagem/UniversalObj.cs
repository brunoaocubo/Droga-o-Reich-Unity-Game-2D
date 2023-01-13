using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//O sistema criado aqui será para utilização de variáveis geral padrão dentro de objetos interativos, com o intuito de reduzir Scripts.
public class UniversalObj : MonoBehaviour
{
    //Variável de texto dentro do jogo (Instrução/Fala).
    [SerializeField] GameObject keyTxT;
    

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    //Se o player colidir com um objeto interativo o texto específico irá aparecer, vice-versa.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            keyTxT.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        keyTxT.SetActive(false);
    }
}
