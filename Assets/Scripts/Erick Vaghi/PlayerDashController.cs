using System;
using UnityEngine;

public class PlayerDashController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidBody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private PlayerWalkController playerWalkController;

    //public float speedMoltiplier { get; private set; }
    public float dashMoltiplier = 5f;
    
    [SerializeField] private float dashLenght = 5f;
    [SerializeField] private float dashCoolDown = 1f;
    [SerializeField] private bool isDashing = false;

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
        if (commandContainer.dashCommand && !isDashing)
        {
            dashMoltiplier = 5;
            isDashing = true;
        }

        while (isDashing)
        {
            dashLenght -= Time.deltaTime;
            if (dashLenght <= 0)
            {
                dashMoltiplier = 1;
                isDashing = false;
            }
        }
    }
}
