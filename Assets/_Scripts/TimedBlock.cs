using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedBlock : MonoBehaviour
{
    MeshRenderer mr;
    BoxCollider bc;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
        bc = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        mr.enabled = ButtonScript.pressed;
        bc.enabled = ButtonScript.pressed;
    }
}
