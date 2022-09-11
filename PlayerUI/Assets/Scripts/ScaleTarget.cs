using UnityEngine;

public class ScaleTarget : MonoBehaviour
{
    public Transform Target;
    void Update() => transform.position = Target.position;
}
