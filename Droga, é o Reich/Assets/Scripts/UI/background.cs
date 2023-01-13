using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public Sprite[] sprites;
    SpriteRenderer spriteRenderer;

    public float speed = 2f;
    bool next = false;
    int index = 0;

    float FirstTime = 3, SecondTime = 3;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        spriteRenderer.sprite = sprites[index];

        FirstTime -= Time.deltaTime;

        if(FirstTime <= 0)
        {
            FirstTime = 3;
            next = !next;
            SecondTime = 3;
            
        }
        if (next)
        {
            FadeOut();

            SecondTime -= Time.deltaTime;

            if (SecondTime <= 0)
            {
                index++;
            }

            if (index > 2)
            {
                index = 0;
            }
        }
        else
        {
            FadeIn();
        }
    }

    void FadeIn()
    {
        spriteRenderer.color = Color.Lerp(spriteRenderer.color, Color.black, speed * Time.deltaTime);
    }
    void FadeOut()
    {
        spriteRenderer.color = Color.Lerp(spriteRenderer.color, Color.white,speed * Time.deltaTime);
    }
}
