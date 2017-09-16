using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpiderCam : MonoBehaviour {

	public Transform Spider;
//	Vector3 somePos;
	public float distance;

	public GameObject MC1, MC2;

	// Use this for initialization
	void Start () {
		transform.LookAt (Spider);

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Spider.transform.GetComponent<KeyboardContoller>().flipped !=0) {
			if (Spider.transform.GetComponent<KeyboardContoller> ().flipped == 1) {
				MC2.SetActive(true);
				for (int i = 0; i < MC1.transform.parent.childCount; ++i) {
					//MC1.transform.parent.GetChild (i).GetComponent<Material> ().color = Color.black;
				}

				MC1.SetActive(false);
			}else{
				if(Spider.transform.GetComponent<KeyboardContoller> ().flipped == 2)
				{
					
					MC1.SetActive(true);
					for (int i = 0; i < MC2.transform.parent.childCount; ++i) {
						//MC2.transform.parent.GetChild (i).GetComponent<Material> ().color = Color.black;
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
