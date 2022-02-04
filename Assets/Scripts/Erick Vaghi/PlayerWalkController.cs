using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    
    public float walkSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        HandleWalking();
    }
    
    private void HandleWalking()
    {
        //Get move input
        var moveInput = Input.GetAxis("Horizontal");
      
        //Apply moveSpeed to rigidbody
        myRigidBody.velocity = new Vector3(walkSpeed * moveInput, myRigidBody.velocity.y, 0);
    }
}
