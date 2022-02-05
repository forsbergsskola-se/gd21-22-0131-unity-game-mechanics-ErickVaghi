using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    
    public float jumpForce = 500f;

    public PlayerInputController playerInputController;

    public GroundChecker myGroundChecker;
    
    void Update()
    {
        HandleJump();
    }
    private void HandleJump()
    {
        //If we pressed the jump button: then jump
        if (playerInputController.jumpInputDown && myGroundChecker.isGrounded)
            myRigidBody.AddForce(0, jumpForce, 0);
    }
}
