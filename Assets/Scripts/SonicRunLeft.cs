using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicRunLeft : MonoBehaviour
{
    public float moveSpeed = 3f; // speed velocity
    public float velX = 0.0f; // horizontal velocity
    public float velY = 0.0f; // vertical velocity
    public bool facingLeft = true; // control sprite flipping

    Rigidbody2D rb2d; // Store a reference to the Rigidbody2D component required to use 2D Physics

    // Start is called before the first frame update
    void Start()
    {
        // Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = -8.48f;

        //Store the current vertical input in the float moveVertical.
        float moveVertical = -2.65f;

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * moveSpeed);
    }
}
