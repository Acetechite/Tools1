using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CubeController : MonoBehaviour {

	public Component[] facialComp;
	public Vector3 myPosition;
	public Transform head;
	public float headScale = 1f;

	void OnEnable(){
		facialComp = GetComponentsInChildren<Transform> ();
		foreach (Transform trans in facialComp) {
			if (trans.tag == "Head")
				head = trans;
		}
		Debug.Log (head.tag);
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (myPosition.x, myPosition.y, myPosition.z);
		head.localScale = new Vector3 (head.localScale.x, headScale, head.localScale.z);
	}
}
