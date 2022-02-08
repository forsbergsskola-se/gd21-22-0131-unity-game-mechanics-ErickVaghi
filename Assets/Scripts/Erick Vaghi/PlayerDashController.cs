using System;
using UnityEngine;

public class PlayerDashController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private PlayerInputController myPlayerInputController;
    [SerializeField] private PlayerWalkController playerWalkController;

    //public float speedMoltiplier { get; private set; }
    public float dashMoltiplier = 3f;
    
    [SerializeField] private float dashTime = 5f;
    [SerializeField] private float dashTimeCounter = 0f;
    //[SerializeField] private float dashCoolDown = 1f;
    //[SerializeField] private float nextDash;
    [SerializeField] private bool isDashing;
    
    public float verticalVelocityMultiplier = 1f; 
    
    [SerializeField] private CameraShake cameraShake;

    private float originalSpeed;
    private float tempWalkSpeed; 

    private void Start()
    {
        isDashing = false;
        //dashMoltiplier = 1f;
        originalSpeed = playerWalkController.walkSpeed;
    }

    private void Update()
    {
        //HandleDash();
        //if (Time.time > nextDash)
        //{
            if (commandContainer.dashCommand && !isDashing)
            {
                //cameraShake.Shake(.15f, 40f);
                tempWalkSpeed = playerWalkController.walkSpeed * dashMoltiplier;
                playerWalkController.walkSpeed = tempWalkSpeed;
                verticalVelocityMultiplier = 0;
                dashTimeCounter = dashTime;
                //nextDash = Time.time + dashCoolDown;
                //Debug.Log("dashing");
                myPlayerInputController.enabled = false;
                commandContainer.dashCommand = false;
                isDashing = true;
                Debug.Log(isDashing);
            }
            if (isDashing)
            {
                Debug.Log("start counting");
                dashTimeCounter -= Time.deltaTime;
                Debug.Log(dashTimeCounter);
                if (dashTimeCounter <= 0)
                {
                    Debug.Log("stopped dashing");
                    myPlayerInputController.enabled = true;
                    verticalVelocityMultiplier = 1;
                    playerWalkController.walkSpeed = originalSpeed;
                    isDashing = false;
                }
            }
        //}
    }

    /*void HandleDash()
    {
        if (Time.time > nextDash)
        {
            if (commandContainer.dashCommand && !isDashing)
            {
                //cameraShake.Shake(.15f, 40f);
                tempWalkSpeed = playerWalkController.walkSpeed * dashMoltiplier;
                playerWalkController.walkSpeed = tempWalkSpeed;
                verticalVelocityMultiplier = 0;
                dashTimeCounter = dashTime;
                nextDash = Time.time + dashCoolDown;
                //Debug.Log("dashing");
                myPlayerInputController.enabled = false;
                commandContainer.dashCommand = false;
                isDashing = true;
                Debug.Log(isDashing);
            }
            if (isDashing)
            {
                Debug.Log("start counting");
                dashTimeCounter -= Time.deltaTime;
                Debug.Log(dashTimeCounter);
                if (dashTimeCounter <= 0)
                {
                    Debug.Log("stopped dashing");
                    myPlayerInputController.enabled = true;
                    verticalVelocityMultiplier = 1;
                    playerWalkController.walkSpeed = originalSpeed;
                    isDashing = false;
                }
            }
        }
    }*/
}

// if (Time.time > nextDash)
// {
//     if (commandContainer.dashCommand)
//     {
//         //cameraShake.Shake(.15f, 40f);
//         tempWalkSpeed = playerWalkController.walkSpeed * dashMoltiplier;
//         playerWalkController.walkSpeed = tempWalkSpeed;
//         verticalVelocityMultiplier = 0;
//         dashTimeCounter = dashTime;
//         nextDash = Time.time + dashCoolDown;
//         //Debug.Log("dashing");
//         myPlayerInputController.enabled = false;
//         commandContainer.dashCommand = false;
//     }
//     else
//     {
//         dashTimeCounter -= Time.deltaTime;
//     }    
//     if (dashTimeCounter <= 0)
//     {
//         //Debug.Log("stopped dashing");
//         myPlayerInputController.enabled = true;
//         verticalVelocityMultiplier = 1;
//         playerWalkController.walkSpeed = originalSpeed;
//     }
// }
// }