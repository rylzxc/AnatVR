using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableThrowAndGravity : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

}
