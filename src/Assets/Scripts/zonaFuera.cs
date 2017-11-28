using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonaFuera : MonoBehaviour {
	public GameObject Control;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "bola") {
			Control.SendMessage ("SaleFuera");
		}
	}
}
