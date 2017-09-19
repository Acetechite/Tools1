using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ConeController : MonoBehaviour {
    
    //Material
	public Renderer rend;
	public Material myMaterial;

    //Size
    public float myScaleX;
    public float myScaleY;
    public float myScaleZ;

	//Stats
	public float xpValue;
	public float maxHealth =1f;
	public float damage =1f;



	// Use this for initialization
	void OnEnable() {
        //Assign component renderer to variable
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
        //Change scale depending on variables
		transform.localScale = new Vector3 (myScaleX, myScaleY, myScaleZ);
        
        //Set material by value
		rend.sharedMaterial = myMaterial;

		//Set EXP
		xpValue = maxHealth+damage*2;
	}
}
