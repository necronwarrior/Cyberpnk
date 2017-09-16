using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

	// Use this for initialization
	Camera camera;
	public bool flipHorizontal;
	void Start () {
		camera = GetComponent<Camera>();
	}
	void OnPreCull() {
		camera.ResetWorldToCameraMatrix();
		camera.ResetProjectionMatrix();
		Vector3 scale = new Vector3(flipHorizontal ? -1 : 1, 1, 1);
		camera.projectionMatrix = camera.projectionMatrix * Matrix4x4.Scale(scale);
	}
	void OnPreRender () {
		GL.invertCulling = flipHorizontal;
	}

	void OnPostRender () {
		GL.invertCulling = false;
	}

}
