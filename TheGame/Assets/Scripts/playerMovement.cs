using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody rb;
    //private float speedx = 10f;
    //private float jump = 3f;
    public Transform orientation;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(10f, 3f, 1f); ;
        }
        
        //else if (Input.GetKey("a"))
        //{
        //    rb.angularVelocity = new Vector3(rb.velocity.x, rb.velocity.y, -speedx) ;
            

        //}
        //else if (Input.GetKey("s"))
        //{
        //    rb.angularVelocity = new Vector3(speedx * -1f, rb.velocity.y, rb.velocity.x);
            

        //}
        //else if (Input.GetKey("d"))
        //{
        //    rb.angularVelocity = new Vector3(rb.velocity.x, rb.velocity.y, speedx);
            

        //}
        //else if (Input.GetKey("space"))
        //{
        //    rb.angularVelocity = new Vector3(rb.velocity.x, jump, rb.velocity.x);

        //}

    }
}
