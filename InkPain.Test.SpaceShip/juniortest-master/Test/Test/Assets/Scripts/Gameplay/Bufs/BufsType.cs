using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufsType : MonoBehaviour,IBufsType
{
    [SerializeField]
    private int _type;

    public int Typees => _type;
}
