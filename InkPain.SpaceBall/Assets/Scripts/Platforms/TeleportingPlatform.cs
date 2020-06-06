using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingPlatform : MonoBehaviour
{
    public GameObject teleport;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.transform.position = teleport.transform.position;
        }
    }
}
