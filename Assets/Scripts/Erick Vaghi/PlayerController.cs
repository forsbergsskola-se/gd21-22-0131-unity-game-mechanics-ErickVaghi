using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidBody;
    
    public float moveSpeed = 5f;
    
    // Update is called once per frame
    void Update()
    {
        //Get move input
        var moveInput = Input.GetAxis("Horizontal");
      
        //Apply moveSpeed to rigidbody
        myRigidBody.velocity = new Vector3(moveSpeed * moveInput, 0, 0);
    }
}
