using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public Transform onhand;

	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown(){
        //GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = onhand.position;
        this.transform.parent = GameObject.Find("FPS").transform;
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }

    void OnMouseUp(){
        this.transform.parent = null;
        //GetComponent<Rigidbody>().useGravity = true;
    }
}
