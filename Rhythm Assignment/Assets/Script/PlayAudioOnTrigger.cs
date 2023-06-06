using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTrigger : MonoBehaviour
{
    public AudioClip clip;
    //public AudioSource source;
    public string targetTag;


    public Animator animator_guy;
    public Animator aimator_women;
    public Animator aimator_men;

    void Start()
    {
        //source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            //source.PlayOneShot(clip);
            aimator_men.SetTrigger("Bboy");
            animator_guy.SetTrigger("Move");
            aimator_women.SetTrigger("Rumba");
        }

    }
}
