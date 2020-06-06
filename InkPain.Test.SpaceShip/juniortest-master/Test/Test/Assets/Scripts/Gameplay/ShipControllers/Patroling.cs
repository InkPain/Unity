using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : MonoBehaviour
{
    Vector3 startPos;
    public bool backAndForth;
    public float travelDistance;
    public float speed;
    public bool reverse;
    public bool x;
    public bool y;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CheckTheObj();
        PingPongStart();
    }



    public void PingPongStart()
    {
        if (backAndForth)
        {
            if (reverse)
            {
                if (x)
                {
                    transform.position = new Vector3(startPos.x - Mathf.PingPong(speed * Time.time, travelDistance), transform.position.y, transform.position.z);
                }
                if (y)
                {
                    transform.position = new Vector3(transform.position.x, startPos.y + Mathf.PingPong(speed * Time.time, travelDistance), transform.position.z);
                }
                else
                {
                    if (x)
                    {
                        transform.position = new Vector3(startPos.x + Mathf.PingPong(speed * Time.time, travelDistance), transform.position.y, transform.position.z);
                    }
                    if (y)
                    {
                        transform.position = new Vector3(transform.position.x, startPos.y + Mathf.PingPong(speed * Time.time, travelDistance), transform.position.z);
                    }
                }
            }
        }
    }

    public void CheckTheObj()
    {
        if (gameObject.tag == "LiftPlatform")
        {
            backAndForth = true;
            reverse = true;
            y = true;
        }
    }
}
