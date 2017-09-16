using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Matrix4x4 mat = GetComponent<Camera>().projectionMatrix;
		mat *= Matrix4x4.Scale(new Vector3(-1, 1, 1));
		GetComponent<Camera>().projectionMatrix = mat;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
