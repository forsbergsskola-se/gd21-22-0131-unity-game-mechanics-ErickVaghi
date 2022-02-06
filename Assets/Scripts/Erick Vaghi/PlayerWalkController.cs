using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private float walkSpeed = 5f;

    void Update()
    {
        HandleWalking();
    }
    
    private void HandleWalking()
    {
        //Apply moveSpeed to rigidbody
        myRigidBody.velocity = new Vector3(walkSpeed * playerInputController.WalkInput, myRigidBody.velocity.y, 0);
    }
}
