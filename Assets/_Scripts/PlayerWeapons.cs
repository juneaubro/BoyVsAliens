using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    void Update()
    {
        ShootLazerPistol();
    }
    void ShootLazerPistol()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Bang!");
        }
    }
}
