using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D))]
public class mueveBola : MonoBehaviour {
	Rigidbody2D rb;
	public float velocidad;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Barra") {
			float x = GolpeaBarra (transform.position, coll.transform.position, coll.collider.bounds.size.x);
			Vector2 dir = new Vector2 (x, 1).normalized;
			rb.velocity = dir * velocidad;
		}
	}

	float GolpeaBarra(Vector2 bolaPos, Vector2 barraPos, float anchuraBarra)
	{
		return (bolaPos.x - barraPos.x) / anchuraBarra;
	}
}
