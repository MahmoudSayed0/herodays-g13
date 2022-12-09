using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinnerTable : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject[] dishes;


    void OnMouseDown()
    {
        audioSource.Play();
        dishes[0].SetActive(true);
        dishes[1].SetActive(false);

    }
}
