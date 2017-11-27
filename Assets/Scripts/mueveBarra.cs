using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mueveBarra : MonoBehaviour {
	Rigidbody2D rb;
	public GameObject Bola;
	public float velocidad;
	public float fuerza_impulso;
	bool lanzado;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!lanzado) {
			LanzaBola ();
		}
	}
	void FixedUpdate() {
		float x = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (x, 0) * velocidad;



		if (Input.GetKey (KeyCode.Space)) {
			if (!lanzado) {
				Bola.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * fuerza_impulso, ForceMode2D.Impulse);
				lanzado = true;
			}
		}
	}

	void Reinicia()
	{
		lanzado = false;
	}


	void LanzaBola()
	{
		// la bola se mueve con la barra
		float off_y = GetComponent<SpriteRenderer> ().bounds.size.y;
		Vector3 bola_pos = new Vector3 (transform.position.x, transform.position.y + off_y, 0);
		Bola.transform.position = bola_pos;

	}
}

