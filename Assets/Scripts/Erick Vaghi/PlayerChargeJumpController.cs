using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    
    [SerializeField] private GroundChecker myGroundChecker;

    [SerializeField] private CommandContainer commandContainer;
    
    [SerializeField] private float minimumJumpForce = 100f;
    [SerializeField] private float maximumJumpForce = 1000f;
    [SerializeField] private float jumpChargeTime = 1f;
    private float chargeProgress = 0f;
    
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (commandContainer.jumpCommand && myGroundChecker.IsGrounded)
        {
            //Increase charge progress, dividing Time.deltaTime let us control how many seconds it takes to charge a full jump.
            chargeProgress += Time.deltaTime / jumpChargeTime;
        }
        
        //If we pressed the jump button: then jump
        if (commandContainer.jumpCommandUp && myGroundChecker.IsGrounded)
        {
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, chargeProgress);
            myRigidBody.AddForce(0, jumpForce, 0);
            //Remember to reset chargeProgress.
            chargeProgress = 0f;
        }
    }
}
