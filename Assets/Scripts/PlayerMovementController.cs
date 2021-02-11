using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] protected float movementSpeed = 5f;
    [SerializeField] protected float jumpForce = 4f;
    [SerializeField] protected float mass = 1f;
    [SerializeField] protected float damping = 5f;

    protected CharacterController characterController;
    protected float velocityY;
    protected Vector3 currentImpact;

    private readonly float gravity = Physics.gravity.y;

    protected virtual void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    protected virtual void Update()
    {
        Move();
        Jump();
    }

    protected virtual void Move()
    {
        Vector3 movementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")).normalized; // normalized is for the greater good, but it makes testing in unity feel so clunky. the movement that is.

        movementInput = transform.TransformDirection(movementInput);

        if(characterController.isGrounded && velocityY < 0f)
        {
            velocityY = 0f;
        }

        velocityY += gravity * Time.deltaTime;

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
        velocityY = 0f;
    }

    public void ResetImpactY()
    {
        currentImpact.y = 0f;
        velocityY = 0f;
    }

    protected virtual void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (characterController.isGrounded)
            {
                AddForce(Vector3.up, jumpForce);
            }
        }
    }

    public void AddForce(Vector3 direction, float magnitude)
    {
        currentImpact += direction.normalized * magnitude / mass;
    }
}
