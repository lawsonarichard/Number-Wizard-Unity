﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number...");
        Debug.Log("The highest number that you can pick is: " + max);
        Debug.Log("The lowest number that you can pick is: " + min);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
