using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//EThan's

public class RayCastEthan : MonoBehaviour {

    // Use this for initialization
    public float fireRate = 0.25f;
    public float range = 50f;
    public float shootForce = 150f;
    public Transform gunPos;
    public bool hitButton = false;
    public bool hitLamp = false;
    public bool door2CanOpen = false;

    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);//how lone th eshot is

    //private LineRenderer laserLine;
    private Camera cam;
    private float nextFire;
    private Inventory_yqc inv;

	void Start () {
        //laserLine = GetComponent<LineRenderer>();
        cam = GetComponentInParent<Camera>();
        inv = GetComponentInParent<Inventory_yqc>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Fire1")&& Time.time>nextFire){
            nextFire = Time.time + fireRate;//time greater the stored time
           // StartCoroutine(Shooting());

            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit, range)){


                if(hit.rigidbody != null && hit.collider.tag == "button"){
                    hitButton = true;
                }
                else if(hit.collider.tag == "lamp"){
                    hitLamp = true;   
                }
                else if(hit.collider.tag == "key2"){
                    Destroy(hit.transform.gameObject);
                    inv.key2 = true;   
                }
                else if(inv.key2 == true && hit.collider.tag == "door2"){
                    door2CanOpen = true;
                }
               
            }


        }

	}

}
