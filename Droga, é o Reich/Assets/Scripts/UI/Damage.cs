using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script usado para relacionar com a HUDControl.
public class Damage : MonoBehaviour
{
    HUDControl hControl; //Chamando o script HUDControl.
    
    public void Start()
    {
        hControl = HUDControl.hControl; 
    }

    private void OnTriggerEnter2D(Collider2D collision) //Atribuindo colisão a tag ''Damage01'' e acionando a LessLife de HUDControl.
    {
        if (collision.gameObject.tag == "Damage01")
        {
            hControl.LessLife();
        }
    }

}
