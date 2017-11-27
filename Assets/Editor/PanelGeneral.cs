using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GeneraLadrillos))]
public class PanelGeneral:Editor {
	public override void OnInspectorGUI() 
	{
		DrawDefaultInspector ();
		GeneraLadrillos myTarget = (GeneraLadrillos)target;
		if (GUILayout.Button ("Construye")) {
			myTarget.PintaColor ();
		}
	}
}
