using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float jumpForce = 10.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0.0f);

        rb.AddForce(movement * moveSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0.0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}