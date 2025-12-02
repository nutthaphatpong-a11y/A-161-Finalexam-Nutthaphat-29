using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movespeed = 5f;
    private float JumpForce = 10f;

    public bool isInvulnerability = false;

    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * movespeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce); 

        } 

        //float JumpInput = Input.GetAxisRaw("Jump");
        //rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
    }

    public void SetMoveSpeed(float amout)
    {
        
    }
    public void SetisInvulnerability(bool a)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Collider2D)
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        
    }

    public void Jump()
    {
        
    }
        
}
