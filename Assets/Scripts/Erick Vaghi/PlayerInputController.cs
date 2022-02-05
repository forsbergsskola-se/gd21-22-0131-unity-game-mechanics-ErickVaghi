using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float walkInput;
    public bool jumpInput;
    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        walkInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetKeyDown(KeyCode.Space);
    }
}
