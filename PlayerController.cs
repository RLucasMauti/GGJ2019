using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    private Rigidbody2D rb;

    public Transform groundCheckPos;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    public Animator animator;
    private bool charRot;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
        groundCheckRadius = 0.3f;
        grounded = false;
        charRot = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            if (charRot)
                FlipChar();
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            if (!charRot)
                FlipChar();
        }

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            grounded = false;
            animator.SetBool("IsJumping", true);
        }
    }

    private void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        if (Physics2D.OverlapCircle(groundCheckPos.position, groundCheckRadius, whatIsGround))
        { 
            animator.SetBool("IsJumping", false);
            grounded = true;
        }
    }

    void FlipChar()
    {
        charRot = !charRot;
        rb.gameObject.transform.Rotate(0, 180, 0);
    }
}
