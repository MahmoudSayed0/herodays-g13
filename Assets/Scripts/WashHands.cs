using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashHands : MonoBehaviour
{
    public AudioSource audioSource;


    void OnMouseDown()
    {
        audioSource.Play();

    }
    void Update()
    {
        if (audioSource.time > 3f)
        {
            audioSource.Stop();
        }
    }
}
