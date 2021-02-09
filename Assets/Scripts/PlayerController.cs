using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform groundCheck;
    public LayerMask groundMask;

    [SerializeField]
    private float maxSpeed = 25f;
    [SerializeField]
    private float gravity = -30f;
    [SerializeField]
    private float jumpHeight = 3f;
    [SerializeField]
    private bool isGrounded;
    [SerializeField]
    private float groundRadius = 3f;

    private Vector3 velocity;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * maxSpeed * Time.deltaTime);

        if (Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        controller.Move(velocity * Time.deltaTime);
    }

    private void LateUpdate()
    {
        //if (isGrounded && velocity.y < 0)
        //{
        //    velocity.y = -1000000f;
        //}

        isGrounded = Physics.CheckSphere(groundCheck.position, groundRadius, groundMask);

        if (!isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(groundCheck.position, groundRadius);
    }
}
