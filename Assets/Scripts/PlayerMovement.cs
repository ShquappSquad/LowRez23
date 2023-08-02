using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 3f;
    public Camera mainCam;

    private float horizontal;
    private float vertical;
    private bool isFacingRight = true;

    // Update is called once per frame
    void Update()
    {
        //Calculate movement
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);

        //Check for player direction
        if(isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if(isFacingRight && horizontal < 0f)
        {
            Flip();
        }
    }

    // Flip the sprite depending on the last direction moved
    private void Flip()
    {
        if(isFacingRight == true)
        {
            Debug.Log("Flipping to face left");
        }
        else if(isFacingRight == false)
        {
            Debug.Log("Flipping to face right");
        }

        isFacingRight = !isFacingRight;
    }

    public void Move(InputAction.CallbackContext context)
    {
       horizontal = context.ReadValue<Vector2>().x; 
       vertical = context.ReadValue<Vector2>().y;
    }
}
