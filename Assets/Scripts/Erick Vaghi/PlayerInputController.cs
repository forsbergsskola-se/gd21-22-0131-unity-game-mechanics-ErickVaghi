using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float walkInput;
    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        walkInput = Input.GetAxis("Horizontal");
    }
}
