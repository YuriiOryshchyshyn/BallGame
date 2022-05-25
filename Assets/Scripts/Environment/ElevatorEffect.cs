using UnityEngine;

public class ElevatorEffect : MonoBehaviour
{
    [SerializeField]
    private float ForceUp;

    private Rigidbody objectRigidbody;

    private void OnTriggerStay(Collider other)
    {
        objectRigidbody = other.gameObject.GetComponent<Rigidbody>();
        objectRigidbody.AddForce(Vector3.up * ForceUp);
    }
}
