using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movespeed = 5f;
    private float JumpForce = 10f;
    public float Health = 10;

    public bool isInvulnerability = false;

    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        Move();
        Jump();
    }

    public void SetMoveSpeed(float amout)
    {
        movespeed *= amout;
        Debug.Log("You get SpeedUP SpeedPlayer" + movespeed);
    }
    public void SetisInvulnerability(bool real)
    {
        isInvulnerability = real;
        Debug.Log("You get Shild");
    }    
    public void TakeDamage(int amout)
    {
        Health -= amout;
        Debug.Log("Ahhhhhhhhhhhhhhhhh");
    }

    public void OnTriggerEnter2D(Collider2D Collider2D)
    {
        GetComponent<PowerUpbase>().ApplyEffect(this);

    }

    public void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * movespeed, rb.linearVelocity.y);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);

        }
    }
        
}
