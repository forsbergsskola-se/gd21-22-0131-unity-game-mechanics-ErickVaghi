using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    public float groundCheckDistance = 1f;
    
    // Update is called once per frame
    void Update()
    {
        //Get move input
        var moveInput = Input.GetAxis("Horizontal");
      
        //Apply moveSpeed to rigidbody
        myRigidBody.velocity = new Vector3(moveSpeed * moveInput, myRigidBody.velocity.y, 0);
        
        //Get Jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        
        //check if we're grounded, using a raycast
        var isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);
        
        //If we pressed the jump button: then jump
        if (jumpInput && isGrounded)
            myRigidBody.AddForce(0, jumpForce, 0);
    }
}
