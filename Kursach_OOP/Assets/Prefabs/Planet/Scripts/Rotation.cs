﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float planetSpeedRotation = 3.0f;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * planetSpeedRotation);
    }
}
