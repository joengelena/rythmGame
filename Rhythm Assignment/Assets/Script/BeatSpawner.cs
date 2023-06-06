using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] spawnPoints;

    public SoundManager soundManager;

    float nextBeatToSpawnNote = 0.0f;
    
    void Update()
    {
        if(soundManager.songPositionInBeats >= nextBeatToSpawnNote)
        {
            SpawnBeat();
            nextBeatToSpawnNote += 4.0f;
        }
    }

    void SpawnBeat()
    {
        Instantiate(cubes[Random.Range(0, cubes.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)]);
    }
}

