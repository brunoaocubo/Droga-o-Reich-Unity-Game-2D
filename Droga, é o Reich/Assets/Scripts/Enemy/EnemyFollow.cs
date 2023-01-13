using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
   [SerializeField]
    private float speed;
   [SerializeField]
    private float StoppingDistance;
   [SerializeField]
    private Transform Target;
   [SerializeField]
    private List<Transform> paths = new List<Transform>();
   [SerializeField]
    public GameObject Personagem;
    
    private int index;

    


    void Start()
    {   //Variável criada para procrurar um objeto que tenha Tag ''player''.
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    void Update()
    {
        if (Personagem.activeInHierarchy == true) // Verfica se o personagem ''oliver'' está ativo.
        {
            Follow(); //Explicação: Linha 45.
        }
        else
        {
            Rotas(); //Explicação: Linha 64.
        }

        //Se a posição do inimigo e a posição do alvo (Geralmente Oliver) 
        if (Vector2.Distance(transform.position, Target.position) < StoppingDistance == false) 
        {                   
            Rotas(); 
        }
    }
    
    void Follow()
    {
        if (Vector2.Distance(transform.position, Target.position) < StoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
        }
        
        float posX = Target.transform.position.x - transform.position.x;
        
        if (posX > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }

    void Rotas()
    {
        transform.position = Vector2.MoveTowards(transform.position, paths[index].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, paths[index].position) < 0.1f)
        {
            if (index < paths.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }

        Vector2 direction = paths[index].position - transform.position;
        if (direction.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (direction.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
}
