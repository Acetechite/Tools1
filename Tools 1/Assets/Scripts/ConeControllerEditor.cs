using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ConeController))]
public class ConeControllerEditor : Editor {

	//This is where i make the fields that will tie into those on the controller
	SerializedProperty myMaterial;
    SerializedProperty myScaleX;
	SerializedProperty myScaleY;
    SerializedProperty myScaleZ;
	SerializedProperty maxHealth;
	SerializedProperty damage;
	SerializedProperty xpValue;

	// Use this for initialization
	void OnEnable () {
		myMaterial = serializedObject.FindProperty ("myMaterial");
        myScaleX = serializedObject.FindProperty("myScaleX");
		myScaleY = serializedObject.FindProperty ("myScaleY");
        myScaleZ = serializedObject.FindProperty("myScaleZ");
		maxHealth = serializedObject.FindProperty ("maxHealth");
		damage = serializedObject.FindProperty ("damage");
		xpValue = serializedObject.FindProperty ("xpValue");
	}
	
	// Update is called once per frame
	public override void OnInspectorGUI () {
		serializedObject.Update (); //call update funstion of Cone Controller
		EditorGUILayout.PropertyField (myMaterial);
        EditorGUILayout.Slider(myScaleX, 0.2f, 1f);
		EditorGUILayout.Slider (myScaleY, 0.2f, 1f);
        EditorGUILayout.Slider(myScaleZ, 0.2f, 1f);
		EditorGUILayout.PropertyField (maxHealth);
		EditorGUILayout.PropertyField (damage);
		EditorGUILayout.LabelField ("XP Value:", xpValue.floatValue.ToString());
		serializedObject.ApplyModifiedProperties ();//?????
	}
}
