using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public ButtonEthan button;
    private Animator animator;
    public bool open;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(button.pressed){
            open = true;
            animator.SetTrigger("open");
        }
	}
}
