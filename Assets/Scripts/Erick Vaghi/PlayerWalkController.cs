using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private PlayerDashController playerDashController;
    public float walkSpeed = 5f;

    void Update()
    {
        HandleWalking();
    }
    
    private void HandleWalking()
    {
        //Apply moveSpeed to rigidbody
        myRigidBody.velocity = new Vector3(walkSpeed * commandContainer.walkCommand * playerDashController.dashMoltiplier, myRigidBody.velocity.y, 0);
    }
}
