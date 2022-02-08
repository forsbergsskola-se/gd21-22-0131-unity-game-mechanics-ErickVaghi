using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private PlayerDashController myPlayerDashController;
    public float walkSpeed = 5f;

    void Update()
    {
        HandleWalking();
    }
    
    private void HandleWalking()
    {
        //Apply moveSpeed to rigidbody
        myRigidBody.velocity = new Vector3(walkSpeed * commandContainer.walkCommand, myRigidBody.velocity.y * myPlayerDashController.verticalVelocityMultiplier, 0);
    }
}
