using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnTrigger_Drum : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip clip;
    public AudioSource source;
    public string targetTag;

    public Animator animator_guy;
    public Animator aimator_women;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            source.PlayOneShot(clip);

            animator_guy.SetTrigger("BreakDance");
            aimator_women.SetTrigger("Hiphop");

        }
    }
}
