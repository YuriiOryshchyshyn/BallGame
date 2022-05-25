using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform cameraTramsform;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - cameraTramsform.position;
    }

    private void FixedUpdate()
    {
        cameraTramsform.position = transform.position - offset;
    }
}
