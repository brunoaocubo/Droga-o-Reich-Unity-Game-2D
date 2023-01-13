using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Vector2 moveInput;

    private Rigidbody2D rig;
    private Animator anim;
    private Vector3 facingright;
    private Vector3 facingleft;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        facingright = transform.localScale;
        facingleft = transform.localScale;
        facingleft.x = facingleft.x * -1;
    }


    void Update()
    {
        Move();
    }

    void Move()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.Translate(moveInput * Time.deltaTime * speed);

        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            transform.localScale = facingright;

        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            transform.localScale = facingleft;


        }

        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk", false);
        }

        if (Input.GetAxis("Vertical") > 0f)
        {
            anim.SetBool("walk", true);

        }

        if (Input.GetAxis("Vertical") < 0f)
        {
            anim.SetBool("walk", true);

        }

    }
}