using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CubeController : MonoBehaviour {

	public Component[] facialComp;
	public Vector3 myPosition;
	public Transform head;
	public float headScale = 1f;
	public Color color;
	public MeshRenderer meshRender;

	void OnEnable(){
		

		facialComp = GetComponentsInChildren<Transform> ();
		foreach (Transform trans in facialComp) {
			if (trans.tag == "Head")
				head = trans;
		}
		Debug.Log (head.tag);
		meshRender = head.GetComponent<MeshRenderer> ();
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (myPosition.x, myPosition.y, myPosition.z);
		head.localScale = new Vector3 (head.localScale.x, headScale, head.localScale.z);
		meshRender.materials [0].color = color;
		Debug.Log (meshRender.materials [0]);

	}
}
