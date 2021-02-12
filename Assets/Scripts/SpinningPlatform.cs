using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPlatform : MonoBehaviour
{
    public bool RandomValues;
    public bool RandomSpinSpeed;

    [SerializeField] private float spinZSpeed;
    [SerializeField] private float spinXSpeed;
    [SerializeField] private float spinYSpeed;
    [SerializeField] private float spinSpeed;
    [SerializeField] private float randomMin;
    [SerializeField] private float randomMax;
    [SerializeField] private float randSpinSpeedMin;
    [SerializeField] private float randSpinSpeedMax;

    private float spinZ;
    private float spinX;
    private float spinY;

    private void Update()
    {
        transform.localRotation = Quaternion.Euler(transform.localRotation.z + spinZ, transform.localRotation.x + spinX, transform.localRotation.y + spinY);

        if (RandomValues)
        {
            spinZ += Random.Range(randomMin, randomMax);
            spinX += Random.Range(randomMin, randomMax);
            spinY += Random.Range(randomMin, randomMax);
        }
        else
        {
            spinZ += spinZSpeed;
            spinX += spinXSpeed;
            spinY += spinYSpeed;
        }

        if (RandomSpinSpeed)
        {
            if ((spinZ + spinX + spinY) > Random.Range(randSpinSpeedMin, randSpinSpeedMax))
            {
                spinZ = 0;
                spinX = 0;
                spinY = 0;
            }
        }

        if((spinZ + spinX + spinY) > spinSpeed)
        {
            spinZ = 0;
            spinX = 0;
            spinY = 0;
        }
    }
}
