using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Transform target; // The target point
    public float speed = 5f; // Speed of the car

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 direction = (target.position - rb.position).normalized;
            Vector3 movePosition = rb.position + direction * speed * Time.fixedDeltaTime;
            rb.MovePosition(movePosition);
        }
    }
}   
