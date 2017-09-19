using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ConeController : MonoBehaviour {
    
	public Renderer rend;
	public Material myMaterial;
	public float myScaleX;
    public float myScaleY;
    public float myScaleZ;

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
		transform.localScale = new Vector3 (myScaleX, myScaleY, myScaleZ);
		rend.sharedMaterial = myMaterial;

		//Set EXP
		xpValue = maxHealth+damage*2;
	}
}
