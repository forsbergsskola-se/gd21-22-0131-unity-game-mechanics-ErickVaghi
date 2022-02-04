using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    
    public float jumpForce = 500f;

    public GroundChecker myGroundChecker;
    
    void Update()
    {
        HandleJump();
    }
    private void HandleJump()
    {
        //Get Jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        
        //If we pressed the jump button: then jump
        if (jumpInput && myGroundChecker.isGrounded)
            myRigidBody.AddForce(0, jumpForce, 0);
    }
}
