using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinnerMission : MonoBehaviour
{
    public GameObject[] dishes;
    public AudioSource audio;

    // Update is called once per frame
    void Update()
    {
        bool flag = true;
        for (int i = 0; i < dishes.Length; i++)
        {

            if (dishes[i].activeSelf)
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
