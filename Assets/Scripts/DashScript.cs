using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovementController))]
public class DashScript : MonoBehaviour
{
    public static bool isDashing;

    [SerializeField]
    private float dashForce;
    [SerializeField]
    private float dashDura;

    PlayerMovementController playerMovementController;

    private void Start()
    {
        playerMovementController = GetComponent<PlayerMovementController>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Dash());
        }
    }

    public IEnumerator Dash()
    {
        playerMovementController.AddForce(Camera.main.transform.forward, dashForce);

        yield return new WaitForSeconds(dashDura);

        playerMovementController.ResetImpact();
    }
}
