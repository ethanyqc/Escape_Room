﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenDoor : MonoBehaviour {

    public CubeKey cb;
    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(cb.cbKey){
            animator.SetTrigger("hidenOn");
        }
	}
}
