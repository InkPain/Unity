using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Transform objToFollow;
    Vector3 deltaPos;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        deltaPos = transform.position - objToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objToFollow.position + deltaPos;
    }
}
