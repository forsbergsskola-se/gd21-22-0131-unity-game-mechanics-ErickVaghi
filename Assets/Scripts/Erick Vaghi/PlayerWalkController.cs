using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    public PlayerInputController playerInputController;
    public float walkSpeed = 5f;

    void Update()
    {
        HandleWalking();
    }
    
    private void HandleWalking()
    {
        //Apply moveSpeed to rigidbody
        myRigidBody.velocity = new Vector3(walkSpeed * playerInputController.walkInput, myRigidBody.velocity.y, 0);
    }
}
