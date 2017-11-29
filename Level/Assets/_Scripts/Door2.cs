using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour {

    public RayCastEthan shot;
    private Animator animator;
    public bool door2Opend = false;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (shot.door2CanOpen)
        {
            door2Opend = true;
            animator.SetTrigger("door2open");
        }
	}
}
