using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [HideInInspector] public float walkInput;
    [HideInInspector] public bool jumpInputDown;
    [HideInInspector] public bool jumpInput;
    [HideInInspector] public bool jumpInputUp;
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
