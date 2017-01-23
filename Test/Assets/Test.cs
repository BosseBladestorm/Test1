using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    int a = 7;
    int b = 69;
    int c = 0;
	// Use this for initialization
	void Start () {
        Debug.Log(a);
        Debug.Log(b);
        c = a;
        a = b;
        b = c;
        Debug.Log(a);
        Debug.Log(b);

    }
	
	// Update is called once per frame
	void Update () {

	}
}
