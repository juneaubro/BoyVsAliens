using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAlienAudio : MonoBehaviour

   
{
    public AudioSource alienRoar;
    public GreenAlienAI detect;

    // Start is called before the first frame update
    void Start()
    {
       alienRoar = GetComponent<AudioSource>();
       detect = GetComponent<GreenAlienAI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (detect == true)
        {
            alienRoar.Play();
        }
        
    }
}
