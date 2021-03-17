using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    private bool shoot;

    void FixedUpdate()
    {
        ShootLazerPistol();
    }
    void ShootLazerPistol()
    {
        if (shoot)
        {
            Debug.Log("Bang!");
            shoot = false;
        }
    }

    public void shootbtn()
    {
        shoot = true;
    }
}
