using UnityEngine;

public class JumpGravityChanger : MonoBehaviour
{
    [SerializeField] private float fallMultiplier = 2.5f;
    [SerializeField] private float lowJumpMultiplier = 2f;
    
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    void Update()
    {
        ImprovedJump();
    }

    void ImprovedJump()
    {
        if (myRigidbody.velocity.y < 0)
        {
            myRigidbody.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (myRigidbody.velocity.y > 0 && !commandContainer.jumpCommand)
        {
            myRigidbody.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}
