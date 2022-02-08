using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    public float WalkInput;
    public bool JumpInputDown { get; private set; }
    public bool JumpInput { get; private set; }
    public bool JumpInputUp { get; private set; }
    public bool DashInputDown { get; private set; }
    
    public bool DashInput { get; private set; }
    
    public bool DashInputUp { get; private set; }
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
        DashInputDown = Input.GetKeyDown(KeyCode.LeftShift);
        DashInput = Input.GetKey(KeyCode.F);
        DashInputUp = Input.GetKeyUp(KeyCode.F);
    }

    private void SetCommands()
    {
        commandContainer.walkCommand = WalkInput;
        commandContainer.jumpCommand = JumpInput;
        commandContainer.jumpCommandDown = JumpInputDown;
        commandContainer.jumpCommandUp = JumpInputUp;
        commandContainer.dashCommandDown = DashInputDown;
        commandContainer.dashCommand = DashInput;
        commandContainer.dashCommandUp = DashInputUp;
    }
}
