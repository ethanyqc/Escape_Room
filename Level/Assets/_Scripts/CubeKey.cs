using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKey : MonoBehaviour {

    public bool cbKey = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "trigerForHiden")
        {
            cbKey = true;
        }
    }
}
