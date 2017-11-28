using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class powerUp : MonoBehaviour {
	float duration = 5f;  // effect only 5 seconds
	public float time = 0;
	bool power = false;
	public string powerName = "";
	// Update is called once per frame
	void Update () 
	{
		if (time < 0) {
			PostRun ();
			Destroy (gameObject);
		}

		if (power) {
			time -= Time.deltaTime;
			Run ();
		}
	}

	void OnTriggerEnter2D(Collider2D coll) 
	{
		if (coll.gameObject.tag == "barra") {
			print (powerName);
			PreRun (coll.gameObject);
			power = true;
			time = duration;
		}
	}

	public abstract void Run ();
	public abstract void PreRun (GameObject player);
	public abstract void PostRun ();
}
