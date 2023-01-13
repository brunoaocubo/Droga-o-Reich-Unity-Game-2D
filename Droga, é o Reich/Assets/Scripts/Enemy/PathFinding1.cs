using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding1 : MonoBehaviour
{
    public float speed;
    private int index;
    
    [SerializeField] 
    private List<Transform> paths = new List<Transform>();
   
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, paths[index].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, paths[index].position) <0.1f)
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
    }
}
