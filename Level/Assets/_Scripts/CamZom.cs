﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamZom : MonoBehaviour {

    int zoom = 20;
    int normal = 60;
    float smooth = 5;

    private bool isZoomed = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isZoomed = !isZoomed;
        }

        if (isZoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }
        else
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);

        }
    }
}
