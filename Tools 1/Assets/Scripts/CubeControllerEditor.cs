using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(CubeController))]
public class CubeControllerEditor : Editor {
	SerializedProperty myPosition;
	SerializedProperty headScale;

	void OnEnable(){
		myPosition = serializedObject.FindProperty ("myPosition");
		headScale = serializedObject.FindProperty ("headScale");
	}

	public override void OnInspectorGUI(){
		serializedObject.Update ();
		EditorGUILayout.PropertyField (myPosition);
		EditorGUILayout.LabelField ("In put this here");
		EditorGUILayout.Slider (headScale, 1f, 3f);
		serializedObject.ApplyModifiedProperties ();
	}
}
