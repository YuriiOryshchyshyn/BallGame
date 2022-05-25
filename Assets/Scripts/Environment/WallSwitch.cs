using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSwitch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
