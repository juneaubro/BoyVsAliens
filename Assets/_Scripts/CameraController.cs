using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Touch initTouch = new Touch();
    public Camera cam;
    public Joystick joystick;
    public float mouseSens = 100f;

    //private float rotX = 0f;
    //private float rotY = 0f;
    //private Vector3 origRot;
    private float XRotation = 0f;

    public float rotSpeed = 0.5f;
    public float dir = -1f;

    private GameObject playerBody;

    private void Start()
    {
        //origRot = cam.transform.eulerAngles;
        //rotX = origRot.x;
        //rotY = origRot.y;   
        playerBody = GameObject.Find("Player");
    }

    private void FixedUpdate()
    {
        float mouseX = joystick.Horizontal;
        float mouseY = joystick.Vertical;

        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = (Quaternion.Euler(XRotation, 0f, 0f));
        playerBody.transform.Rotate(Vector3.up * mouseX);

        //if (Input.touchCount >= 2 || PlayerMovementController.isMoving == false)
        //{
        //    foreach (Touch touch in Input.touches)
        //    {
        //        if (touch.phase == TouchPhase.Began)
        //        {
        //            initTouch = touch;
        //        }
        //        else if (touch.phase == TouchPhase.Moved)
        //        {
        //            float deltaX = initTouch.position.x - touch.position.x;
        //            float deltaY = initTouch.position.y - touch.position.y;
        //            rotX -= deltaY * Time.deltaTime * rotSpeed * dir;
        //            rotY += deltaX * Time.deltaTime * rotSpeed * dir;
        //            rotX = Mathf.Clamp(rotX, -80f, 80f);
        //            cam.transform.eulerAngles = new Vector3(rotX, rotY, 0f);
        //        }
        //        else if (touch.phase == TouchPhase.Ended)
        //        {
        //            initTouch = new Touch();
        //        }
        //    }
        //}
    }
}
