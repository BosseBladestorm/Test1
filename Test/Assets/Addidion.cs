using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addidion : MonoBehaviour {
    int a = 33;
    int b = 36;
    int c = 0;
	// Use this for initialization
	void Start () {
        // Puts c as the addition of a and b.
        c = a + b;
        // Prints out c
        Debug.Log (c);
        // adds togheter a and b and prints them.
        Debug.Log (a + b);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
