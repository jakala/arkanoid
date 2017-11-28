using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruyeLadrillo : MonoBehaviour {
	GameObject Control;
	public GameObject[] powerUp;
	int powerUpLength; 

	void Awake ()
	{
		Control = GameObject.Find ("CONTROL");
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		powerUpLength = powerUp.Length;

		int r = Random.Range (0, powerUpLength + 10);
		if(( 0<= r)  && (r <powerUpLength) ) {
			print ("aleatorio = " + r);
			print ("powerupLength = " + powerUpLength);
			GameObject clonePowerUp = Instantiate (powerUp[r].gameObject, transform.position, Quaternion.identity) as GameObject;
		}
		Control.SendMessage ("SumaPuntos");
		controlJuego.ladrillos_nivel--;

		Destroy(gameObject);

	}
	float GolpeaBarra(Vector2 bolaPos, Vector2 barraPos, float anchuraBarra)
	{
		return (bolaPos.x - barraPos.x) / anchuraBarra;
	}

}
