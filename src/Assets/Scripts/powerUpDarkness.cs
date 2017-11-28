using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpDarkness : powerUp {
	GameObject fondo;

	public override void PreRun(GameObject Player)
	{
		powerName = "Darkness";
		fondo = GameObject.Find ("Arkanoid_fondo");
		fondo.GetComponent<SpriteRenderer> ().enabled =false;
		GameObject[] ladrillos = GameObject.FindGameObjectsWithTag("ladrillo");
		foreach (GameObject ladrillo in ladrillos) {
			ladrillo.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}

	public override void PostRun()
	{
		fondo.GetComponent<SpriteRenderer> ().enabled = true;
		GameObject[] ladrillos = GameObject.FindGameObjectsWithTag("ladrillo");
		foreach (GameObject ladrillo in ladrillos) {
			ladrillo.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}

	public override void Run()
	{
	}
}
