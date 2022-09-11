using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTarget : MonoBehaviour
{
    public Transform Target;

    void Update()
    {
        transform.position = Target.position;
    }
}
