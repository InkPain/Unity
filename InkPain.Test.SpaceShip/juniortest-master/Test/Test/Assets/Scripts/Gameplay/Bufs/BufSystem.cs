using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject Object;

    Transform deltapos;
    private void Start()
    {
        deltapos = GetComponent<Transform>();
    }
    public void TriggerSpawn()
    {
        Instantiate(Object, deltapos.position, deltapos.rotation);
    }
}
