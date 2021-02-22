using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

   
    private bool isGrounded;

    public AudioSource playerSounds;
    public AudioClip jumpSound;
    public AudioClip dashSound;
    public AudioClip walkSound;
    public AudioClip swooshSound;

    private bool pauseWalk;

    CharacterController cc;
    
  
    // Start is called before the first frame update
    void Start()
    {
        playerSounds = GetComponent<AudioSource>();
        isGrounded = GetComponent<PlayerMovementController>();
        cc = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerSounds.PlayOneShot(jumpSound);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSounds.PlayOneShot(swooshSound);
            playerSounds.PlayOneShot(jumpSound);
            
        }

        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && playerSounds.isPlaying == false)
        {
            playerSounds.PlayOneShot(walkSound, 0.5f);
        }
       

    }
}
