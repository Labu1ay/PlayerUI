using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Transform CameraTransform;
    void Update()
    {
        Vector3 ToCamera = CameraTransform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(ToCamera);
    }
}
