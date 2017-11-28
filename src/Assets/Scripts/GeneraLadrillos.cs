using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneraLadrillos : MonoBehaviour {
	public GameObject ladrillo_sencillo;
	public Texture2D imagen;
	Color32[] colores;
	// Use this for initialization

	// Update is called once per frame
	public void PintaColor() 
	{
		colores = imagen.GetPixels32 ();
		float altura = ladrillo_sencillo.GetComponent<SpriteRenderer> ().bounds.size.y;
		float anchura= ladrillo_sencillo.GetComponent<SpriteRenderer> ().bounds.size.x;

		int cont = 0;
		for (int i = 0; i < imagen.height; i++) {
			for (int j = 0; j < imagen.width; j++) {
				if ((colores[cont]) != Color.white) {
					// creo un nuevo GameObject

					ladrillo_sencillo.GetComponent<SpriteRenderer>().color = colores[cont];
					GameObject nuevo = (GameObject) Instantiate(ladrillo_sencillo, new Vector3(j*anchura, i*altura ,0), Quaternion.identity);

					nuevo.tag = "bloque";
					nuevo.name = "cuadro" + i + "_" + j;
				}
				cont++;
			}
		}

		print ("hay " + cont + " ladrillos");
	}
}
