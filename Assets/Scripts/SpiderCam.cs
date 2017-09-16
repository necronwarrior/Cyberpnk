using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiderCam : MonoBehaviour {

	public Transform Spider;
//	Vector3 somePos;
	public float distance;


	Material[] matList1 , matList2;
	public Material shadowMat;
	public GameObject MC1, MC2;
	Transform Z1LevelContainer, Z2LevelContainer;

	// Use this for initialization
	void Start () {
		transform.LookAt (Spider);
		Z1LevelContainer = MC1.transform.parent.GetChild (0);
		Z2LevelContainer = MC2.transform.parent.GetChild (0);

		matList1 = new Material[Z1LevelContainer.childCount];

		for (int i = 0; i < Z1LevelContainer.childCount; ++i) {
			matList1[i] = Z1LevelContainer.GetChild (i).GetComponent<MeshRenderer> ().material;
		}

		matList2 = new Material[Z2LevelContainer.childCount];

		for (int i = 0; i < Z2LevelContainer.childCount; ++i) {
			matList2[i] = Z2LevelContainer.GetChild (i).GetComponent<MeshRenderer> ().material;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Spider.transform.GetComponent<KeyboardContoller>().flipped !=0) {
			if (Spider.transform.GetComponent<KeyboardContoller> ().flipped == 2) {
				MC2.SetActive(true);
				for (int i = 0; i < Z1LevelContainer.childCount; ++i) {
					Z1LevelContainer.GetChild (i).GetComponent<MeshRenderer> ().material = shadowMat;
				}
				for (int i = 0; i < Z2LevelContainer.childCount; ++i) {
					Z2LevelContainer.GetChild (i).GetComponent<MeshRenderer> ().material = matList2[i];
				}

				MC1.SetActive(false);
			}else{
				if(Spider.transform.GetComponent<KeyboardContoller> ().flipped == 1)
				{
					
					MC1.SetActive(true);
					for (int i = 0; i < Z2LevelContainer.childCount; ++i) {
						Z2LevelContainer.GetChild (i).GetComponent<MeshRenderer> ().material = shadowMat;
					}
					for (int i = 0; i < Z1LevelContainer.childCount; ++i) {
						Z1LevelContainer.GetChild (i).GetComponent<MeshRenderer> ().material = matList1[i];
					}

					MC2.SetActive(false);
				}
			}

		}
		//transform.position = (transform.position - Spider.transform.position).normalized*distance + Spider.transform.position;


		//somePos= Spider.transform.position;
		//transform.RotateAround (somePos, Vector3.up, 20 * Time.deltaTime);

		transform.LookAt (Spider);
	}
}
