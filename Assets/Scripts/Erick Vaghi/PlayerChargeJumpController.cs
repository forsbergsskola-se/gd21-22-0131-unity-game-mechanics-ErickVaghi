using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    
    public GroundChecker myGroundChecker;

    public PlayerInputController playerInputController;
    
    public float minimumJumpForce = 100f;
    public float maximumJumpForce = 1000f;
    public float jumpChargeTime = 1f;
    private float chargeProgress = 0f;
    
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (playerInputController.jumpInput && myGroundChecker.isGrounded)
        {
            //Increase charge progress, dividing Time.deltaTime let us control how many seconds it takes to charge a full jump.
            chargeProgress += Time.deltaTime / jumpChargeTime;
        }
        
        //If we pressed the jump button: then jump
        if (playerInputController.jumpInputUp && myGroundChecker.isGrounded)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, chargeProgress);
            myRigidBody.AddForce(0, jumpForce, 0);
            //Remember to reset chargeProgress.
            chargeProgress = 0f;
        }
    }
}
