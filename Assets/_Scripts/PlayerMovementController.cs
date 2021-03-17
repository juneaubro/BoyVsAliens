using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 20f;
    [SerializeField] private float jumpForce = 60f;
    [SerializeField] private float mass = 1f;
    [SerializeField] private float damping = 6f;
    [SerializeField] private float gravityMultiplier = 1f;
    [SerializeField] private Joystick joystick;

    private bool jB;

    private CharacterController characterController;
    private float velocityY;
    private float jumpCount = 0;
    private Vector3 currentImpact;

    private readonly float gravity = Physics.gravity.y;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        Move();

        if (jB)
        {
            Jump();
            jB = false;
        }

        if (characterController.isGrounded)
        {
            jumpCount = 0;
        }
    }

    private void Move()
    {
        Vector3 movementInput = new Vector3(joystick.Horizontal, 0f, joystick.Vertical).normalized; // normalized is for the greater good, but it makes testing in unity feel so clunky. the movement that is.

        movementInput = transform.TransformDirection(movementInput);

        if(characterController.isGrounded && velocityY < 0f)
        {
            velocityY = 0f;
        }

        velocityY += gravity * gravityMultiplier * Time.deltaTime;

        Vector3 velocity = movementInput * movementSpeed + Vector3.up * velocityY;

        if(currentImpact.magnitude > 0.2f)
        {
            velocity += currentImpact;
        }

        characterController.Move(velocity * Time.deltaTime);

        currentImpact = Vector3.Lerp(currentImpact, Vector3.zero, damping * Time.deltaTime);
    }

    public void ResetImpact()
    {
        currentImpact = Vector3.zero;
        //velocityY = 0f;
    }

    public void ResetImpactY()
    {
        currentImpact.y = 0f;
        velocityY = 0f;
    }

    public void Jump()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{


            if (jumpCount == 0)
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
            else if (jumpCount == 1)
            {
                ResetImpactY();
                AddForce(Vector3.up, jumpForce);

                jumpCount = 2;
            }
        //}
    }

    public void jBtnC()
    {
        jB = true;
    }

    public void AddForce(Vector3 direction, float magnitude)
    {
        currentImpact += direction.normalized * magnitude / mass;
    }
}
