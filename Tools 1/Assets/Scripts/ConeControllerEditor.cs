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
    public GUIStyle titles;

	// Use this for initialization
	void OnEnable () {
        //All serializedproperties here are assigned to variables in ConeController.cs of the same name
		myMaterial = serializedObject.FindProperty ("myMaterial");
        myScaleX = serializedObject.FindProperty("myScaleX");
		myScaleY = serializedObject.FindProperty ("myScaleY");
        myScaleZ = serializedObject.FindProperty("myScaleZ");
		maxHealth = serializedObject.FindProperty ("maxHealth");
		damage = serializedObject.FindProperty ("damage");
		xpValue = serializedObject.FindProperty ("xpValue");

        //This is a new font setting that lets me bold labels
        titles = new GUIStyle();
        titles.fontStyle = FontStyle.Bold;
	}
	
	// Update is called once per frame
	public override void OnInspectorGUI () {
		serializedObject.Update (); //call update function of Cone Controller
		EditorGUILayout.PropertyField (myMaterial);

        //All size attributes
        GUILayout.Label("Size",titles);
        EditorGUI.indentLevel++;
        EditorGUILayout.Slider(myScaleX, 0.2f, 1f);
		EditorGUILayout.Slider (myScaleY, 0.2f, 1f);
        EditorGUILayout.Slider(myScaleZ, 0.2f, 1f);
        EditorGUI.indentLevel--;

        //All stats attributes
        GUILayout.Label("Stats", titles);
        EditorGUI.indentLevel++;
        EditorGUILayout.PropertyField (maxHealth);
		EditorGUILayout.PropertyField (damage);
		EditorGUILayout.LabelField ("XP Value:", xpValue.floatValue.ToString());
        EditorGUI.indentLevel--;

        serializedObject.ApplyModifiedProperties ();//?????
	}
}
