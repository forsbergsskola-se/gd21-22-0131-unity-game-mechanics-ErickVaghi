using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float WalkInput { get; private set; }
    public bool JumpInputDown { get; private set; }
    public bool JumpInput { get; private set; }
    public bool JumpInputUp { get; private set; }
    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        WalkInput = Input.GetAxis("Horizontal");
        
        JumpInputDown = Input.GetKeyDown(KeyCode.Space);
        JumpInput = Input.GetKey(KeyCode.Space);
        JumpInputUp = Input.GetKeyUp(KeyCode.Space);
    }
}
