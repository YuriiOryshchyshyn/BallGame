using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private Transform portalOut;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = portalOut.position;
    }
}
