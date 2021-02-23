using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public static float dampen;

    [SerializeField] private float Offset;
    [SerializeField] private float dampening;

    private bool dir = true;
    private bool running = true;

    Vector3 newPositivePos;
    Vector3 newNegativePos;

    private void Start()
    {
        dampen = dampening;
        newPositivePos = new Vector3(transform.position.x, transform.position.y, transform.position.z + Offset);
        newNegativePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void LateUpdate()
    {
        dampening = dampen;

        // move left
        //if (transform.position != newPositivePos && dir == true)
        //{
        //    transform.position = Vector3.Lerp(transform.position, newPositivePos, dampening);

        //    if(((newPositivePos.z) - (transform.position.z)) < 2)
        //    {
        //        dir = false;
        //    }
        //}

        //if(transform.position != newNegativePos && dir == false)
        //{
        //    transform.position = Vector3.Lerp(transform.position, newNegativePos, dampening);

        //    if (((newNegativePos.z) - (transform.position.z)) < 2) // fuck two x 2
        //    {
        //        dir = true;
        //    }
        //}

        if (transform.position.z <= newPositivePos.z && running == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + dampening); // moves left

            if (transform.position.z >= newPositivePos.z)
                running = false;
        }

        if(transform.position.z >= newNegativePos.z && running == false)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - dampening);

            if (transform.position.z <= newNegativePos.z)
                running = true;
        }

        // Debug.Log($"Running = {running}\nTpos.z = {transform.position.z}\nnewpos = {newPositivePos.z}\nnewneg = {newNegativePos.z}");
    }
}
