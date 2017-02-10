using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableConvertion : MonoBehaviour {
    public int a = 69;
    public int b = 351;
    int c = 0;

    int add(int left, int right)
    {
        return left + right;
    }
	// Use this for initialization
	void Start () {
        // Combines a and b to c.
        c = add(a, b);
        //prints c.
        Debug.Log(c);
        // Checks if add worked correctly.
        Debug.Log(a + b);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
