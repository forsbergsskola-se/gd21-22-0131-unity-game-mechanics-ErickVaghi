using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float walkInput;
    public bool jumpInputDown;
    public bool jumpInput;
    public bool jumpInputUp;
    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        walkInput = Input.GetAxis("Horizontal");
        
        jumpInputDown = Input.GetKeyDown(KeyCode.Space);
        jumpInput = Input.GetKey(KeyCode.Space);
        jumpInputUp = Input.GetKeyUp(KeyCode.Space);
    }
}
