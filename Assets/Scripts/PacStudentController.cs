using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       string lastInput = "nothing";
        if (Input.GetButtonDown("w"))
        {
            lastInput = "w";
        }
        if (Input.GetButtonDown("a"))
        {
            lastInput = "a";
        }
        if (Input.GetButtonDown("s"))
        {
            lastInput = "s";
        }
        if (Input.GetButtonDown("d"))
        {
            lastInput = "d";
        }
    }
}
