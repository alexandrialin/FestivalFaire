﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball") && gameObject.CompareTag("Basket"))
        {
            Points.addthePoints(10);
        }
    }
}
