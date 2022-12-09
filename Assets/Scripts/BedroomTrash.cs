using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomTrash : MonoBehaviour
{
    public AudioSource audioSource;
    public int counterDel = 0;
    void OnMouseDown()
    {   
        audioSource.Play();
        gameObject.SetActive(false);
        Debug.Log(counterDel);

    }
    public void ButtonClick()
    {
        
         counterDel++;

    }
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
                counterDel++;


    }
}
