using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardContoller : MonoBehaviour {

	public GameObject Zone1, Zone2;
	public Transform child;
	public float val, lastTime;
	public int flipped;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		lastTime = Time.deltaTime;
		flipped = 0;
		rb = GetComponent<Rigidbody> ();
		child = transform.GetChild (0);
	}
	
	// Update is called once per frame
	void Update () {
		lastTime += Time.deltaTime;
		 val = Input.GetAxis ("Switch");
		if (val>0 && lastTime> 2.0f) {
			if(transform.parent == Zone1.transform)
			{
				transform.parent = Zone2.transform;
				transform.localPosition= new Vector3 (transform.position.x,
					transform.position.y,
					0.0f);
				flipped = 1;
				//child.rotation = Quaternion.Euler (0.0f, 180.0f, 0.0f);
			}else if(transform.parent == Zone2.transform)
			{
				transform.parent = Zone1.transform;
				transform.localPosition= new Vector3 (transform.position.x,
					transform.position.y,
					0.0f);
				flipped = 2;
				//child.rotation = Quaternion.Euler (0.0f, -180.0f, 0.0f);
			}
			lastTime = 0.0f;

		}

		val = Input.GetAxis ("Horizontal");
		if (val == 0) {
			rb.velocity *= 0.9f;
		}else{if(val>0)
			{
			rb.AddForce (transform.forward * 20.0f);
		}else
			rb.AddForce (-transform.forward * 20.0f);
		}

		val = Input.GetAxis ("Jump");
		if (val>0 && lastTime> 2.0f) {
			rb.AddForce (transform.up * 1000.0f);
			lastTime = 0.0f;
		}
	}
}
