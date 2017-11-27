using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpWall : powerUp {
	GameObject wall;
	public override void PreRun(GameObject player)
	{
		powerName = "Wall";
		wall = GameObject.FindWithTag ("wall");
		wall.GetComponent<SpriteRenderer> ().enabled = true;
		wall.GetComponent<Collider2D> ().enabled = true;
		print (wall.name);
		wall.SetActive (true);
	}

	public override void PostRun()
	{
		wall.GetComponent<SpriteRenderer> ().enabled = false;
		wall.GetComponent<Collider2D> ().enabled = false;
	}

	public override void Run()
	{
	}

}
