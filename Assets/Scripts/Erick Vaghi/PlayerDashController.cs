using UnityEngine;

public class PlayerDashController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private float dashForce = 10;
    void Update()
    {
        HandleDash();
    }

    void HandleDash()
    {
        //If we pressed the jump button: then jump
        if (commandContainer.dashCommand)
            myRigidBody.AddForce(dashForce, 0, 0);
    }
}
