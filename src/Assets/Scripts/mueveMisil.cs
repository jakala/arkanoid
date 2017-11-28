using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mueveMisil : MonoBehaviour {
	Rigidbody2D rb;
	public float velocidad;
	public float fuerza_impulso;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate()
	{
		rb.velocity = Vector2.up * velocidad;

//		rb.AddForce (Vector2.up * fuerza_impulso, ForceMode2D.Impulse);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		Destroy (gameObject);
	}
}
