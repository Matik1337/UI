﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.layer == 9)
            Destroy(gameObject);
    }
}
