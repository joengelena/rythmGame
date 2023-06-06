using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimatorOnTrigger : MonoBehaviour
{
    public string targetTag;


    public Animator animator_guy;
    public Animator aimator_women;
    public Animator aimator_men;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            aimator_men.SetTrigger("HeadSpin");
            animator_guy.SetTrigger("BreakDance");
            aimator_women.SetTrigger("Hiphop");
            aimator_men.SetTrigger("Salsa");
        }
    }
}
