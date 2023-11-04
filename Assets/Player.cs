using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;
    private bool isGrounded;
    [SerializeField] private Transform groundCheck; // the object which is attached at the bottom of the player to check for the ground
    [SerializeField] private LayerMask groundLayer; //this layer will be checkf for ground

    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private float groundCheckOffset = 0.1f; //circle radious from the bottom of the player to check for ground

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckOffset, groundLayer);
        Vector2 inputVector = inputManager.GetMovementVector();

        rb.velocity = new Vector2(inputVector.x * moveSpeed, rb.velocity.y);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
