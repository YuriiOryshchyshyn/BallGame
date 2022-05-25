using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float Speed = 0;

    private Rigidbody playerRigidbody;

    private void Start()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        playerRigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal") * Speed * Time.fixedDeltaTime,
            0f, Input.GetAxis("Vertical") * Speed * Time.fixedDeltaTime));
    }
}
