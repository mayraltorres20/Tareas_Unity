﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaLuz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D MovDer = GetComponent<Rigidbody2D>();
        MovDer.AddForce(new Vector2(-1,0), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
