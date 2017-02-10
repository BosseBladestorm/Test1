using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastScript : MonoBehaviour
{
    int a = 1;
    int b = 69;
    int c = 5;
    int add (int left, int right)
    {
        return left + right;
    }
    // Use this for initialization
    void Start()
    {
        //combines a and b.
        c = add(a, c);

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
}


