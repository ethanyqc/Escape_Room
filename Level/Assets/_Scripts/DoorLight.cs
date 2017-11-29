using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLight : MonoBehaviour {

    public Door door;
    //public Color color;
    private Light lt;
	// Use this for initialization
	void Start () {
        lt = GetComponent<Light>();
        //color = GetComponent<Renderer>().material.color;

	}
	
	// Update is called once per frame
	void Update () {
        if(door.open){
            lt.color = Color.green;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
	}
}
