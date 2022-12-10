using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour
{
    public GameObject[] trash;
    public AudioSource audio;

    // Update is called once per frame
    void Update()
    {
        bool flag = true;
        for (int i = 0; i < trash.Length; i++)
        {

            if (trash[i].activeSelf)
            {
                flag = false;
            }
        }

        if (flag)
        {
            audio.Play();
            gameObject.SetActive(false);
        }

    }
}
