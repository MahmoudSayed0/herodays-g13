using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinnerTable : MonoBehaviour
{
    public GameObject[] dishes;


    void OnMouseDown()
    {
        dishes[0].SetActive(true);
        dishes[1].SetActive(false);

    }
}
