using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpShooter : powerUp {
	public GameObject rocket;
	GameObject player;
	float rocketCadence = 0.2f;
	float espera = 0;
	void Start()
	{
		powerName = "shooter";
	}

	public override void PreRun(GameObject barra)
	{
		player = barra;
	}

	public override void PostRun()
	{
	}

	public override void Run()
	{
		if (Input.GetKey (KeyCode.Space)) {
			if (espera < Time.time) {
				espera = Time.time + rocketCadence;
				Vector3 direccion = new Vector3 (player.transform.position.x, player.transform.position.y + .60f, 0);
				GameObject cloneRocket = Instantiate (rocket, direccion, Quaternion.identity) as GameObject; 
			}
				
		}
			
	}
}
