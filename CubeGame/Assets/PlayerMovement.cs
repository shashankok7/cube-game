﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sideForce = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce,0,0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce,0,0);
        }

     

    }
}
