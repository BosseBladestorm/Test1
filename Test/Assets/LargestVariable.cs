using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargestVariable : MonoBehaviour {
    int a = 4004;
    int b = 420;
    
	// Use this for initialization
	void Start () {
        // Checks if a is bigger than b.
		if (a > b)
        {
            // Prints a if a is bigger
            Debug.Log ("a");
        }
        else
        {
            //prints b if b is bigger
            Debug.Log ("b");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
