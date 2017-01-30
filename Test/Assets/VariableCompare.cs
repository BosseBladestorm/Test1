using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableCompare : MonoBehaviour {
    int a = 1;
    int b = 69;
    int c = 5;
	// Use this for initialization
	void Start () {
        if (a > b && a < c || a > c && a < b)
        {
            print("a");
        }
        else if (b > a && b < c || b < a && b > c)
        {
            print("b");
        }
        else
        {
            print("c");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
