﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float lifeTime = 5f;
        
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    
}
