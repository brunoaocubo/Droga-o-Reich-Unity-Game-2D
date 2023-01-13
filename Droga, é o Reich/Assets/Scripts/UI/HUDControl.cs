using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDControl : MonoBehaviour
{
    public static HUDControl hControl { get; private set; }
    public GameObject Player;
   
    //Vida do Personagem.
    public int life = 3;
    public GameObject[] heartHUD = new GameObject[3];

    private void Awake() //Chamando a função hcontrol antes de tudo iniciar ''Awake''.
    {
        if (hControl == null)
        {
            hControl = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LessLife() //Vida perdida do personagem.
    {
        life--;
        LifeHUD();
    }

    public int Life() //Retornar o valor da vida atual.
    {
        return life;
    }

    //Troca de imagens do personagem baseado na vida atual.
    public void LifeHUD()
    {
        //Condição para não exceder a vida perdida ou a vida ganha (não atribuida).
        if (life <= 0)
        {
            life = 0;
            Destroy(Player);
            SceneManager.LoadScene("GameOver");
            
        }
        else if (life >= 3)
        {
            life = 3;
        }

        switch (life)
        {
            case 3:
                heartHUD[0].SetActive(false);
                heartHUD[1].SetActive(false);
                heartHUD[2].SetActive(true);
                break;

            case 2:
                heartHUD[0].SetActive(false);
                heartHUD[1].SetActive(true);
                heartHUD[2].SetActive(false);
                break;

            case 1:
                heartHUD[0].SetActive(true);
                heartHUD[1].SetActive(false);
                heartHUD[2].SetActive(false);
                break;

            default:
                heartHUD[0].SetActive(false);
                heartHUD[1].SetActive(false);
                heartHUD[2].SetActive(false);
                break;
        }
      
    }
}
