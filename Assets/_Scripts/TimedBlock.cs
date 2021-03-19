using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedBlock : MonoBehaviour
{
    MeshRenderer mr;
    BoxCollider bc;

    bool clickedEBtn;

    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
        bc = GetComponent<BoxCollider>();
    }

    private void FixedUpdate()
    {
        if (clickedEBtn)
        {
            StartCoroutine(BlockTimer());
        }
    }

    public IEnumerator BlockTimer()
    {
        clickedEBtn = false;

        mr.enabled = true;
        bc.enabled = true;

        yield return new WaitForSeconds(15);

        mr.enabled = false;
        bc.enabled = false;
    }

    public void clickedE()
    {
        clickedEBtn = true;
    }
}
