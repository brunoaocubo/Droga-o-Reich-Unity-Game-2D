using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float rotationSpeed;
    public float distance;
    public LineRenderer lineOfSight;
    public Gradient redColor;
    public Gradient greenColor;
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if(hitinfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitinfo.point, Color.red);
            lineOfSight.SetPosition(1, hitinfo.point);
            lineOfSight.colorGradient = redColor;

            if (hitinfo.collider.CompareTag("Player"))
            {
                Destroy(hitinfo.collider.gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
            lineOfSight.SetPosition(1, transform.position + transform.right * distance);
            lineOfSight.colorGradient = greenColor;
        }

        lineOfSight.SetPosition(0, transform.position); 
    }
}
