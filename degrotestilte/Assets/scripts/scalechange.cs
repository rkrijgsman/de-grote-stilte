﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalechange : MonoBehaviour
{
    private Vector3 scaleChange;

    public GameObject gameObject;
    public float x;
    public float y;
    public float z;
    


    // Start is called before the first frame update
    void Start()
    {
          scaleChange = new Vector3(x, y, z);
          
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += scaleChange;
    }
}
