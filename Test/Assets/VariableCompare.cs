﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableCompare : MonoBehaviour {
    public int a = 1;
    public int b = 69;
    public int c = 5;
	// Use this for initialization
	void Start () {
        // Checks if a is in the middle.
        if (a > b && a < c || a > c && a < b)
        {
            print("a");
        }
        // Checks if b is in the middle if a is not.
        else if (b > a && b < c || b < a && b > c)
        {
            print("b");
        }
        // Prints c if neither a nor b is in the middle.
        else
        {
            print("c");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
