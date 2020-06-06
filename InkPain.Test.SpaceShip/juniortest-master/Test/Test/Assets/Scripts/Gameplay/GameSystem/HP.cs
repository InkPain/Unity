using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    HPSystem healthSystem;

    private void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("Player").GetComponent<HPSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "RightArea" && collision.tag != "LeftArea" && collision.tag != "Buf")
        {
            healthSystem.health = healthSystem.health - 1;
        }
    }
}
