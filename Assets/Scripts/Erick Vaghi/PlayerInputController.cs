using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    public float WalkInput { get; private set; }
    public bool JumpInputDown { get; private set; }
    public bool JumpInput { get; private set; }
    public bool JumpInputUp { get; private set; }
    
    public bool DashInput { get; private set; }
    private void Update()
    {
        GetInput();
        SetCommands();
    }

    private void GetInput()
    {
        WalkInput = Input.GetAxis("Horizontal");
        
        JumpInputDown = Input.GetKeyDown(KeyCode.Space);
        JumpInput = Input.GetKey(KeyCode.Space);
        JumpInputUp = Input.GetKeyUp(KeyCode.Space);
        DashInput = Input.GetKeyDown(KeyCode.LeftShift);
    }

    private void SetCommands()
    {
        commandContainer.walkCommand = WalkInput;
        commandContainer.jumpCommand = JumpInput;
        commandContainer.jumpCommandDown = JumpInputDown;
        commandContainer.jumpCommandUp = JumpInputUp;
        commandContainer.dashCommand = DashInput;
    }
}
