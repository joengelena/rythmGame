using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatBigDrum : MonoBehaviour
{
    [SerializeField]
    float speed = 2.0f;

    public ParticleSystem ParticleSystem;
    public GameObject drumMesh;
    public float lifeTime;

    public Boolean addScore = false;

    private void Start()
    {
        StartCoroutine(Die());
    }


    void Update()
    {

        transform.position += Time.deltaTime * transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        ParticleSystem.Play();
        if (!addScore)
        {
            drumMesh.SetActive(false);
            PlayerSettings.Score += 1;
            PlayerSettings.Drum += 1;
            PlayerSettings.Accuracy += 1;
            addScore = true;
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
        PlayerSettings.Drum += 1;
        PlayerSettings.Accuracy += 1;
        yield return null;
    }
}
