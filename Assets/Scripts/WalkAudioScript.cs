using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAudioScript : MonoBehaviour
{

    public AudioSource walkSound;
    public CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {

        walkSound = GetComponent<AudioSource>();
        cc = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && walkSound.isPlaying == false)
        {
            walkSound.Play();
        }
        else if (cc.isGrounded == false)
        {
            walkSound.Stop();
        }



    }
}
