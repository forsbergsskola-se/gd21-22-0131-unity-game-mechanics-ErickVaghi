using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    
    public float jumpForce = 500f;
    
    public float groundCheckDistance = 0.6f;
    
    public float groundCheckSphereRadius = 0.45f;

    void Update()
    {
        HandleJump();
    }
    private void HandleJump()
    {
        //Get Jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //check if we're grounded, using a raycast
        //Vector3.down: down in world space.
        //-transform.up: down in the GameObject's local space.
        // var isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);

        //Ground checking using sphere cast. Think of it as a sphere being moved along a ray, we hit anything that the sphere touches.
        Ray sphereCastRay = new Ray(transform.position, Vector3.down);
        var isGrounded = Physics.SphereCast(sphereCastRay, groundCheckSphereRadius, groundCheckDistance);

        //Draw a ray in the editor, only for visualization.
        Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.cyan);

        //If we pressed the jump button: then jump
        if (jumpInput && isGrounded)
            myRigidBody.AddForce(0, jumpForce, 0);
    }
}
