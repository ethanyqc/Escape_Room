using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour {

    public RayCastEthan shot;
    private Animator animator;
    //public bool pressed;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shot.hitLamp)
        {
            //pressed = true;
            animator.SetTrigger("lamp_fall");
        }
    }
}
