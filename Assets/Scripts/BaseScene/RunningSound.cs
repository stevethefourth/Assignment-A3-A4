using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip running;
    public AudioClip eating;
    public PacStudentController controller;
    private bool currentlyEating = false;
    private bool playing = false;
    private bool switchedOn = false;
    private float startedTime;
    private float now;
    // Start is called before the first frame update
    void Start()
    {

        
        
        
    }

     //Update is called once per frame
    void Update()
    {
        now += Time.deltaTime;
        if (now > 8f)
        {
            if (controller.eating())
                currentlyEating = true;
            else
                currentlyEating = false;


            if (currentlyEating && playing == false)
            {
                source.Stop();
                source.clip = eating;
                source.loop = true;
                source.volume = 0.5f;
                source.Play();
                playing = true;
                switchedOn = false;
            }
            else if (switchedOn == false && currentlyEating == false)
            {
                source.Stop();
                source.clip = running;
                source.loop = true;
                source.volume = 0.2f;
                source.Play();
                switchedOn = true;
                playing = false;

            }

        }
       
    }
    
}

