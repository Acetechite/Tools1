using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ConeController : MonoBehaviour {

	public Vector3 myPosition;
	public Renderer rend;
	public Material myMaterial;
	public float myScale;

	//Stats
	public float xpValue;
	public float maxHealth =1f;
	public float damage =1f;



	// Use this for initialization
	void OnEnable() {
		rend = GetComponent<Renderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (myPosition.x, myPosition.y, myPosition.z);
		transform.localScale = new Vector3 (transform.localScale.x, myScale, transform.localScale.z);
		rend.sharedMaterial = myMaterial;

		//Set EXP
		xpValue = maxHealth+damage*2;
	}
}
