using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Menu1 {
	// declaramos la opcion de menu
	[MenuItem("MiArkanoid/CreaLadrillos")]
	private static void Hola() 
	{
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				// creo un nuevo GameObject
				GameObject ladrillo = new GameObject ("ladrillo" + i);
				ladrillo.AddComponent<SpriteRenderer> ();
				ladrillo.tag = "Bloque";

				// carga un sprite 
				Sprite misprite = (Sprite)AssetDatabase.LoadAssetAtPath ("Assets/Resources/BaseBlanco.png", typeof(Sprite));
				ladrillo.GetComponent<SpriteRenderer> ().sprite = misprite;
				ladrillo.GetComponent<SpriteRenderer> ().sortingLayerName = "pantalla";
				ladrillo.AddComponent<BoxCollider2D> ();
				ladrillo.AddComponent<Rigidbody2D> ();
				ladrillo.AddComponent<destruyeLadrillo> ();

				// colocar el ladrillo:
				float ancho = ladrillo.GetComponent<SpriteRenderer> ().bounds.size.x;
				float alto = ladrillo.GetComponent<SpriteRenderer> ().bounds.size.y;
				Vector3 nueva_pos = new Vector3 (ancho * i, alto * j, 0);
				ladrillo.transform.position = nueva_pos;
			}
		}
	}

	[MenuItem("MiArkanoid/BorraLadrillos")]
	private static void borra() 
	{
		// almacena en una matriz los gameObject del tag Bloque
		GameObject[] ladrillos = GameObject.FindGameObjectsWithTag("ladrillo");
		foreach (GameObject l in ladrillos) {
			GameObject.DestroyImmediate (l);
		}
	}

	[MenuItem("MiArkanoid/CuentaLadrillos")]
	private static void contar() 
	{
		// almacena en una matriz los gameObject del tag Bloque
		GameObject[] ladrillos = GameObject.FindGameObjectsWithTag("ladrillo");
		Debug.Log ("hay " + ladrillos.Length + " ladrillos");

	}



	[MenuItem("MiArkanoid/Patron")]
	private static void Patron() 
	{
		int[,] patron = { { 1, 2, 3, 4 }, { 0, 0, 1, 3 } };
		Color[] Colores = { Color.black, Color.blue, Color.red, Color.gray, Color.yellow};

		for (int i = 0; i < patron.GetLength(0); i++) {
			for (int j = 0; j < patron.GetLength(1); j++) {
				if ((patron [i,j]) != 0) {
					// creo un nuevo GameObject
					GameObject ladrillo = new GameObject ("ladrillo" + i);
					ladrillo.AddComponent<SpriteRenderer> ();
					ladrillo.tag = "Bloque";

					// carga un sprite 
					Sprite misprite = (Sprite)AssetDatabase.LoadAssetAtPath ("Assets/Resources/BaseBlanco.png", typeof(Sprite));
					ladrillo.GetComponent<SpriteRenderer> ().sprite = misprite;
					ladrillo.GetComponent<SpriteRenderer> ().sortingLayerName = "pantalla";
					ladrillo.AddComponent<BoxCollider2D> ();
					ladrillo.AddComponent<Rigidbody2D> ();
					ladrillo.AddComponent<destruyeLadrillo> ();

					// colocar el ladrillo:
					float ancho = ladrillo.GetComponent<SpriteRenderer> ().bounds.size.x;
					float alto = ladrillo.GetComponent<SpriteRenderer> ().bounds.size.y;
					Vector3 nueva_pos = new Vector3 (ancho * i, alto * j, 0);
					ladrillo.transform.position = nueva_pos;
					ladrillo.GetComponent<SpriteRenderer>().color = Colores[patron[i,j]];
				}
			}
		}
	}

}

