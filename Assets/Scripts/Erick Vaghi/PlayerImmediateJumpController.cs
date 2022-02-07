using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    
    [SerializeField] private float jumpForce = 500f;

    [SerializeField] private CommandContainer commandContainer;

    [SerializeField] private GroundChecker myGroundChecker;
    
    void Update()
    {
        HandleJump();
    }
    private void HandleJump()
    {
        //If we pressed the jump button: then jump
        if (commandContainer.jumpCommandDown && myGroundChecker.IsGrounded)
            myRigidBody.AddForce(0, jumpForce, 0);
    }
}
