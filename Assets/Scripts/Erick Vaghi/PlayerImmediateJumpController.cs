using System;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    [SerializeField] private Rigidbody myRigidBody;
    
    [SerializeField] private float jumpForce = 500f;

    [SerializeField] private CommandContainer commandContainer;

    [SerializeField] private GroundChecker myGroundChecker;

    void Update()
    {
        HandleJump();
        if (myGroundChecker.IsGrounded)
        {
            animator.ResetTrigger("Player is Jumping");
            animator.SetTrigger("Player Stopped Jumping");

        }
        else
        {
            animator.SetTrigger("Player is Jumping");
            animator.ResetTrigger("Player Stopped Jumping");
        }
    }
    private void HandleJump()
    {
        //If we pressed the jump button: then jump
        if (commandContainer.jumpCommandDown && myGroundChecker.IsGrounded)
        {
            myRigidBody.AddForce(0, jumpForce, 0);

        }
        else if(myGroundChecker.IsGrounded)
        {

        }
    }
}
