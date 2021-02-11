using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerMovementController
{
    private int jumpCount = 0;

    protected override void Update()
    {
        base.Update();

        if (characterController.isGrounded)
        {
            jumpCount = 0;
        }
    }

    protected override void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(jumpCount == 0)
            {
                ResetImpactY();
                AddForce(Vector3.up, jumpForce);

                if (characterController.isGrounded)
                {
                    jumpCount = 1;
                }
                else
                {
                    jumpCount = 2;
                }
            }
            else if(jumpCount == 1)
            {
                ResetImpactY();
                AddForce(Vector3.up, jumpForce);
                
                jumpCount = 2;
            }
        }
    }
}
