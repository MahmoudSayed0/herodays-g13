using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomTrash : MonoBehaviour
{
    public AudioSource audioSource;

    void OnMouseDown()
    {
        audioSource.Play();
        gameObject.SetActive(false);
    }
}
