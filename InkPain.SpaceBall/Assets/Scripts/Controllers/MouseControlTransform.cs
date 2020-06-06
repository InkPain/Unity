using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControlTransform : MonoBehaviour

    
{
    public float speed = 50f;
    Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate(Vector3.up, -speed * Time.deltaTime);
        }
    }
}
