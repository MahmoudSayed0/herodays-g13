using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashHands : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource missionAudio;
    public GameObject mission;


    void OnMouseDown()
    {
        audioSource.Play();
        missionAudio.Play();
        mission.SetActive(false);

    }
    void Update()
    {
        if (audioSource.time > 3f)
        {
            audioSource.Stop();
        }
    }
}
