using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    public GameObject platform;

    [SerializeField] private float waitInSeconds;

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(waitInSeconds);

        platform.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(Disappear());
        }
    }
}
