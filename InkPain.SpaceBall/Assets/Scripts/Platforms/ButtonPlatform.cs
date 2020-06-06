using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlatform : MonoBehaviour
{
    public bool buttonPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            buttonPressed = true;
        }
    }
}
