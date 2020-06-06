using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTeleporting : MonoBehaviour
{
    public GameObject teleport;

    private void OnTriggerEnter2D(Collider2D other)
    {
            other.transform.position = new Vector2(teleport.transform.position.x, teleport.transform.position.y);
    }
}
