using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    enum ButtonState
    {
        DOWN,
        STATIC,
        UP
    };

    int buttonState = 2;

    Vector3 downPos;
    Vector3 upPos;

    bool temp;
    bool clicked;

    private void Start()
    {
        upPos = transform.position;
        downPos = new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z);
    }

    private void FixedUpdate()
    {
        if (clicked && temp)
        {
            clicked = false;
            buttonState = (int)ButtonState.DOWN;
        }

        if (buttonState == (int)ButtonState.DOWN)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.005f, transform.position.z);

            if(transform.position.y <= downPos.y)
            {
                buttonState = (int)ButtonState.STATIC;
            }
        }

        if(buttonState == (int)ButtonState.STATIC)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.005f, transform.position.z);

            if(transform.position.y >= upPos.y)
            {
                buttonState = (int)ButtonState.UP;
            }
        }
    }

    public void eButton()
    {
        clicked = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            temp = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            temp = false;
        }
    }
}
