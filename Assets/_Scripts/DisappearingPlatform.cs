using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    public MeshRenderer mr;
    public BoxCollider bc;

    [SerializeField] private float waitInSeconds;

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(waitInSeconds);

        mr.enabled = false;
        bc.enabled = false;

        yield return new WaitForSeconds(waitInSeconds);

        mr.enabled = true;
        bc.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(Disappear());
        }
    }
}
