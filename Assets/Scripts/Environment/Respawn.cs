using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Transform Player;

    private Vector3 StartPlayerPosition;

    private void Start()
    {
        StartPlayerPosition = Player.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player.transform.position = StartPlayerPosition;
    }
}
