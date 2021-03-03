using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    Vector3 downPos;
    Vector3 upPos;

    public static bool pressed = false;

    private void Start()
    {
        upPos = transform.position;
        downPos = new Vector3(transform.position.x, transform.position.y - 8f, transform.position.z);
    }

    private void Update()
    {
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
            if (Input.GetKeyDown(KeyCode.E) && pressed != true)
            {
                pressed = true;
            }
        }
    }
}
