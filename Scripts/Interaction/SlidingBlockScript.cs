﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Scary_event_System.Custom_Event_System;
using System;

public class SlidingBlockScript : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private ParticleSystem _dust;

    //FMOD stuff
    [FMODUnity.EventRef]
    public string SecretPassage = "event:/Environmental/SecretPassage";
    // Start is called before the first frame update
    void Awake()
    {

        _animator = GetComponent<Animator>();

    }

    private void OnEnable()
    {
        EventManager.StartListening("Sliding Door", PlayAnimation);
    }

    private void PlayAnimation()
    {
        _animator.SetTrigger("Slide");
        //Play sound
    }

    private void OnDisable()
    {
        EventManager.StopListening("Sliding Door", PlayAnimation);
    }

    //This function is called in the animation of the same object.
    public void DustParticles(int state)
    {
        switch (state) 
        {
            //0 is off
            case 0:
                _dust.Stop();
                break;
            //1 is on
            case 1:
                _dust.Play();
                break;
        }
    }

    public void OpenSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot(SecretPassage, transform.position);
    }
}
