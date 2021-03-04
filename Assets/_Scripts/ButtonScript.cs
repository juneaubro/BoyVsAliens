using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    Vector3 downPos;
    Vector3 upPos;

    public static bool pressed = false;

    bool temp;

    private void Start()
    {
        upPos = transform.position;
        downPos = new Vector3(transform.position.x, transform.position.y - 9f, transform.position.z);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && pressed != true && temp == true)
        {
            pressed = true;
        }

        if (pressed == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.005f, transform.position.z);

            if(transform.position.y <= downPos.y)
            {
                pressed = false;
                transform.position = upPos;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            temp = true;
        }
    }
}
