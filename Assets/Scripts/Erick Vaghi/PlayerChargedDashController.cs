using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargedDashController : MonoBehaviour
{ 
    [SerializeField] private Rigidbody myRigidBody;
    
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private PlayerInputController myPlayerInputController;
    [SerializeField] private GroundChecker myGroundChecker;
    
    public float dashMoltiplier;
    
    //[SerializeField] private bool isDashing;
    
    [SerializeField] private CameraShake cameraShake;
    
    [SerializeField] private float minDashMultiplier = 100f;
    [SerializeField] private float maxDashMultiplier = 1000f;
    [SerializeField] private float dashChargeTime = 1f;
    private float chargeProgress = 0f;

    [SerializeField] private bool facingRight;

    private void Start()
    {
        facingRight = true;
        //isDashing = false;
    }

    private void Update()
    {
        if (myPlayerInputController.WalkInput < 0)
        {
            facingRight = false;
        }
        else if (myPlayerInputController.WalkInput > 0)
        {
            facingRight = true;
        }
        HandleDash();
    }

    void HandleDash()
    {
        if (commandContainer.dashCommand && myGroundChecker.IsGrounded)
        {
            //Increase charge progress, dividing Time.deltaTime let us control how many seconds it takes to charge a full dash.
            chargeProgress += Time.deltaTime / dashChargeTime;
        }
        
        if (commandContainer.dashCommandUp && myGroundChecker.IsGrounded)
        {
            dashMoltiplier = Mathf.Lerp(minDashMultiplier, maxDashMultiplier, chargeProgress);
            if (facingRight)
            {
                myRigidBody.AddForce(dashMoltiplier * 1, 0, 0);
            }
            else
            {
                myRigidBody.AddForce(dashMoltiplier * (-1), 0, 0);
            }
            //Remember to reset chargeProgress.
            chargeProgress = 0f;
            //myPlayerInputController.enabled = false;
        }
    }
}

