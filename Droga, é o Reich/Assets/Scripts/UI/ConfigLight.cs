using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigLight : MonoBehaviour
{
    [SerializeField]
    private bool Personagem;


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Personagem = true;
        }

    }
}
