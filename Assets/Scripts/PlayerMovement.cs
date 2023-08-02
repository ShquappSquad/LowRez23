using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    private float horizontal;
    private float speed = 1f;
    private bool isFacingRight = true;

    // Update is called once per frame
    void Update()
    {
        //Calculate movement
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

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
        //setTrigger to left or right
    }

    private void Move(InputAction.CallbackContext context)
    {
       horizontal = context.ReadValue<Vector2>().x; 
    }
}
