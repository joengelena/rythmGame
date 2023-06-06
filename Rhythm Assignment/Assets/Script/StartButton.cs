using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class StartButton : MonoBehaviour
{

    public string targetTag;

    public GameObject gameMenuManager;
    public GameObject scoreCanvas;

    public GameObject spawners;
    public GameObject soundManager;

    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == targetTag)
        {
            audioSource.Pause();
            gameMenuManager.SetActive(false);
            scoreCanvas.SetActive(true);
            spawners.SetActive(true);
            soundManager.SetActive(true);
        }
    }
}
