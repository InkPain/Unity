using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointRotation : MonoBehaviour
{
    private Quaternion rotation;

    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        angle++;

        Quaternion rotationX = Quaternion.AngleAxis(angle * 10, Vector3.up);
        Quaternion rotationY = Quaternion.AngleAxis(angle * 10, Vector3.right);

        transform.rotation = rotation * rotationY * rotationX;


    }
}
