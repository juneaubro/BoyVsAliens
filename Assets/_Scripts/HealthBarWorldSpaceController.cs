using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    private Transform playerCamera;

    private void Start()
    {
        playerCamera = GameObject.Find("Main Camera").transform;
    }

    private void LateUpdate()
    {
        transform.LookAt(transform.position + playerCamera.forward);
    }
}
