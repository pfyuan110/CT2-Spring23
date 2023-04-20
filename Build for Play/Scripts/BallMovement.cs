using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float upForce = 200f;
    public float rightForce = 100f;
    public float leftForce = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(rightForce, upForce, leftForce);
    }
}
