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
    [SerializeField]
    private float cooldown;

    private float cooldownCounter = 10;

    PlayerMovementController playerMovementController;
    

    private void Start()
    {
        playerMovementController = GetComponent<PlayerMovementController>();
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && cooldownCounter > cooldown)
        {
            StartCoroutine(Dash());

            cooldownCounter = 0;

            
        }

        cooldownCounter += Time.deltaTime;
    }

    public IEnumerator Dash()
    {
        playerMovementController.AddForce(Camera.main.transform.forward, dashForce);

        yield return new WaitForSeconds(dashDura);

        playerMovementController.ResetImpact();
    }
}
