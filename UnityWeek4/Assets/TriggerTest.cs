﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter()
    {
        Debug.Log("Enter");
    }

    void OnTriggerExit()
    {
        Debug.Log("Exit");
    }
}
