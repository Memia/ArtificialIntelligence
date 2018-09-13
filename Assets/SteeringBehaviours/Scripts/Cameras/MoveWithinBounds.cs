﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithinBounds : MonoBehaviour
{
    public float moveSpeed = 15f;
    public float zoomSpeed = 500f;
    public CameraBounds camBounds;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Move the camera left + right
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Vector3 inputDir = new Vector3(inputH, 0, inputV);
        //position += (direction x speed) x deltaTime
        transform.position += inputDir * moveSpeed * Time.deltaTime;
        // Zoom the amera in + out
        float inputScroll = Input.GetAxis("Mouse ScrollWheel");
        transform.position += transform.forward * inputScroll *zoomSpeed *Time.deltaTime;
// Cap the position to stay within camera bounds
transform.position = camBounds.GetAdjustedPosition(transform.position);

    }
}
