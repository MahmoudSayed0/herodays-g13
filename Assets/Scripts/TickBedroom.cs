using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickBedroom : BedroomTrash
{
    void Start()
    {
        if (counterDel == 5)
            gameObject.SetActive(false);
    }


}
