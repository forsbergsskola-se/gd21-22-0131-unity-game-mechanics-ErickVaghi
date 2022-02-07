using System;
using UnityEngine;

public class PlayerDashController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private PlayerWalkController playerWalkController;

    //public float speedMoltiplier { get; private set; }
    public float dashMoltiplier = 5f;
    
    [SerializeField] private float dashTime = 5f;
    [SerializeField] private float dashTimeCounter = 0f;
    [SerializeField] private float dashCoolDown = 1f;
    //[SerializeField] private bool isDashing = false;
    [SerializeField] private float nextDash;

    private void Start()
    {
        dashMoltiplier = 1f;
    }

    private void Update()
    {
        HandleDash();
    }

    void HandleDash()
    {
        if (Time.time > nextDash)
        {
            if (commandContainer.dashCommand)
            {
                dashMoltiplier = playerWalkController.walkSpeed * 5;
                playerWalkController.walkSpeed = dashMoltiplier;
                dashTimeCounter = dashTime;
                nextDash = Time.time + dashCoolDown;
            }
            else
            {
                dashTimeCounter -= Time.deltaTime;
            }    
            if (dashTimeCounter <= 0)
            {
                dashMoltiplier = 8;
                playerWalkController.walkSpeed = dashMoltiplier;
            }
        }
    }
}
