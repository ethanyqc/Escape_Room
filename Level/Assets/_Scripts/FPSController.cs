using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

    public float speed = 2;
    public float sen= 5;
    CharacterController player;
    public GameObject FPView;

    float movefb;
    float movelr;
    Vector2 rot;
    public float maxAngle = 80;
    public float maxXAngle = 180;



	// Use this for initialization
	void Start () {
        player = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        movefb = Input.GetAxis("Vertical") * speed;
        movelr = Input.GetAxis("Horizontal") * speed;
		rot.x += Input.GetAxis("Mouse X") * sen;
		rot.y -= Input.GetAxis("Mouse Y") * sen;
		rot.x = Mathf.Clamp(rot.x, -maxXAngle, maxXAngle);
		rot.y = Mathf.Clamp(rot.y, -maxAngle, maxAngle);

		FPView.transform.rotation = Quaternion.Euler(rot.y, rot.x, 0);

        if (Input.GetMouseButtonDown(0)){
            Cursor.lockState = CursorLockMode.Locked;
        }


        Vector3 movement = new Vector3(movelr, 0, movefb);


        movement = FPView.transform.rotation* movement;
        player.Move(movement * Time.deltaTime);

	}
}
