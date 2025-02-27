using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 250;
    public int jumpHeight = 15; // Ensure proper initial value
    public bool InAir = false;

    private Rigidbody2D rb2d;

    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        InAir = false;
        Debug.Log("InAir false");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        InAir = true;
        Debug.Log("InAir true");
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 currentVelocity = rb2d.linearVelocity;

        // Horizontal movement
        if (moveHorizontal != 0)
        {
            rb2d.linearVelocity = new Vector2(moveHorizontal * speed, currentVelocity.y);
        }

        // Jumping
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && !InAir)
        {
            rb2d.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            InAir = true; // Mark as in air immediately after jump
        }
    }
}
