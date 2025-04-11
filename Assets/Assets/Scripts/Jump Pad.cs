using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;

        // Apply upward force.

        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }
}