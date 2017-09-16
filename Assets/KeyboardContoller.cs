using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardContoller : MonoBehaviour {

	public GameObject Zone1, Zone2, otherPlayer;
	public Transform child;
	public float val, lastTime;
	public int flipped;
	bool active;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		lastTime = Time.deltaTime;
		flipped = 1;
		rb = GetComponent<Rigidbody> ();
		child = transform.GetChild (0);

		if (transform.parent == Zone1.transform) {
			GetComponent<Rigidbody> ().detectCollisions = true;
			GetComponent<Rigidbody> ().useGravity = true;
			active = true;
		}
		if (transform.parent == Zone2.transform) {
			GetComponent<Rigidbody> ().detectCollisions = false;
			GetComponent<Rigidbody> ().useGravity = false;
			active = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		lastTime += Time.deltaTime;
		 val = Input.GetAxis ("Switch");
		if (val>0) {
			if(flipped == 2)
			{
				flipped = 1;
				if (transform.parent == Zone1.transform) {
					GetComponent<Rigidbody> ().detectCollisions = true;
					GetComponent<Rigidbody> ().useGravity = true;
					active = true;
				}
				if (transform.parent == Zone2.transform) {
					GetComponent<Rigidbody> ().detectCollisions = false;
					GetComponent<Rigidbody> ().useGravity = false;
					active = false;
				}
			}else if(flipped == 1)
			{
				flipped = 2;
				if (transform.parent == Zone1.transform) {
					GetComponent<Rigidbody> ().detectCollisions = false;
					GetComponent<Rigidbody> ().useGravity = false;
					active = false;
				}
				if (transform.parent == Zone2.transform) {
					GetComponent<Rigidbody> ().detectCollisions = true;
					GetComponent<Rigidbody> ().useGravity = true;
					active = true;
				}
			}

		}

		if (active) {
			val = Input.GetAxis ("Horizontal");
			if (val == 0) {
				rb.velocity *= 0.9f;
			} else {
				if (val > 0) {
					rb.AddForce (transform.forward * 20.0f);
				} else
					rb.AddForce (-transform.forward * 20.0f);
			}

			val = Input.GetAxis ("Jump");
			if (val > 0 && lastTime > 2.0f) {
				rb.AddForce (transform.up * 1000.0f);
				lastTime = 0.0f;
			}
		} else {
			transform.position = new Vector3 (otherPlayer.transform.position.x, otherPlayer.transform.position.y, transform.position.z);
		}
	}
}
