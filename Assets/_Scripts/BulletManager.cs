using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeleteThyself());
    }

    public IEnumerator DeleteThyself()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);
    }
}
