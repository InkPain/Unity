using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBufed
{
    void ApplyBuf(int type);

    int Typees { get; }
}
