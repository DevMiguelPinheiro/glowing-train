using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 600;
    private Rigidbody2D rb2d = 5f;
    private bool facingRight = true;
    private bool jump;
    private bool onGround = false;
    private Transform groundCheck;
    private float hForce = 0;
    private bool isDead = false;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        groundCheck = gameObject.transform.Find("GroundCheck");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            onGround = Physics2D.Linecast(tranform.position,groundCheck.position,1<< LayerMask.NameToLayer("Ground"));
            if(Input.GetMouseButton("Jump") && onGround) 
            {
                jump = true;
            }
            else if (Input.GetMouseButton("Jump")) 
            { 
                if(rb2d.velocity.y > 0) 
                { 
                rb2d.velocity.y = 0; = newVector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
                }
            }
        }



    }
}
