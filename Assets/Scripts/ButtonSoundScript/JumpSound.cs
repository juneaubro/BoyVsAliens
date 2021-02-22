using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
  
{
    public AudioClip jumpSound;
    AudioSource audioSource;
    bool isGrounded;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isGrounded = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(isGrounded == false)
        audioSource.PlayOneShot(jumpSound, 0.7F);
    }
}