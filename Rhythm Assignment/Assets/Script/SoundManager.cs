using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    AudioClip musicTrack;

    [SerializeField]
    float firstBeatOffset;

    [SerializeField]
    EndScreen endGame;

    public float songBpm;
    public float songLength;

    public float songPositionInBeats;

    float secPerBeat;
    float songPosition;
    float dspSongTime;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        secPerBeat = 60f / songBpm;
        dspSongTime = (float)AudioSettings.dspTime;
        PlayMusicTrack();
    }

    void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dspSongTime - firstBeatOffset);
        songPositionInBeats = songPosition / secPerBeat;

        if (songPositionInBeats > songLength)
        {
            endGame.EndGame();
        }
    }

    void PlayMusicTrack()
    {
        audioSource.PlayOneShot(musicTrack);
    }
}
