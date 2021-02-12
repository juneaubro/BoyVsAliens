using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float xOffset;
    [SerializeField] private float yOffset;
    [SerializeField] private float zOffset;
    [SerializeField] private float dampening;
    [SerializeField] private float timer;

    private float count = 0f;
    private bool right = false;

    Vector3 newPos;

    private void LateUpdate()
    {
        if (count < timer && right == false)
        {
            newPos = new Vector3(transform.position.x + xOffset, transform.position.y + yOffset, transform.position.z + zOffset);
            transform.position = Vector3.Lerp(transform.position, newPos, dampening);

            count += Time.deltaTime;

            if(count > timer)
            {
                right = true;
                count = 0;
            }
        }
        else if(count < timer && right == true)
        {
            newPos = new Vector3(transform.position.x - xOffset, transform.position.y - yOffset, transform.position.z - zOffset);
            transform.position = Vector3.Lerp(transform.position, newPos, dampening);

            count += Time.deltaTime;

            if (count > timer)
            {
                right = false;
                count = 0;
            }
        }
        
    }
}
