using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlocks : MonoBehaviour
{
    [SerializeField]
    private float PlatformDestroyTime;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
            return;

        Invoke("DestroyPlatform", PlatformDestroyTime);
    }

    private void DestroyPlatform()
    {
        Destroy(gameObject);
    }
}
