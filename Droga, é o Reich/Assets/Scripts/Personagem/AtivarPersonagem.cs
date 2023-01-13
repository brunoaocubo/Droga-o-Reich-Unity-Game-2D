using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarPersonagem : MonoBehaviour
{
    [SerializeField] GameObject Personagem;


    void Update()
    {
        if (Personagem.activeInHierarchy == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Personagem.SetActive(true);
            }
        }
    }
}