using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    Rigidbody rb;
    Vector3 deltaPos;
    bool movingBack;
    float force = 5;
    public float timeLife = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        deltaPos = transform.position;
    }
    void BackPlatform()
    {
        rb.velocity = Vector3.zero;
        rb.isKinematic = true;
        movingBack = true;
        timeLife = 1.5f;
    }
    void FallingPlatformMethod()
    {
        rb.isKinematic = false;
        Invoke("BackPlatform", 5);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            timeLife = timeLife - Time.deltaTime;
            if (timeLife < 0)
            {
                rb.isKinematic = false;
                Invoke("BackPlatform", 5);
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            timeLife = 1.5f;
        }
    }

    private void Update()
    {
        if (movingBack)
        {
            transform.position = Vector3.MoveTowards(transform.position, deltaPos, 2f * Time.deltaTime);
        }

        if (transform.position.y == deltaPos.y)
        {
            movingBack = false;
        }
    }


}
