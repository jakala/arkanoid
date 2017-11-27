using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpMultipleBalls : powerUp {
	public GameObject ball;
	public int fuerzaImpulso =5;
	public override void PreRun(GameObject player)
	{
		Vector3 direccion = new Vector3 (player.transform.position.x, player.transform.position.y + .60f, 0);
		for (int i = -8; i < 8; i+=1) {
			GameObject cloneBall = Instantiate (ball, direccion, Quaternion.identity) as GameObject; 
			Vector2 vectorForce = new Vector2 (i, 1);
			cloneBall.GetComponent<Rigidbody2D> ().AddForce (vectorForce * fuerzaImpulso, ForceMode2D.Impulse);

		}
	}

	public override void PostRun()
	{
	}

	public override void Run()
	{
	}
}
