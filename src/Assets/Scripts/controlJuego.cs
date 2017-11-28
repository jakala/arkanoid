using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controlJuego : MonoBehaviour {
	public GameObject Barra;
	int wait;
	AsyncOperation asyncLoadLevel;
	int maxvidas = 3;
	int vidas;
	public Text puntos_txt;
	bool pantallaCargada = true;
	int puntos;

	// gestion de niveles, tiene el numero de ladrillos del juego
	int nivel = 2;
	public static int ladrillos_nivel;

	// Update is called once per frameW
	void Update () {

		int tmp = GameObject
			.FindGameObjectsWithTag("ladrillo")
			.Length;
		
		if (pantallaCargada) {
			if (tmp <= 0) {
				nivel++;		
				pantallaCargada = false;
				loadLevel (nivel);
				Barra.SendMessage ("Reinicia");
				Barra.SendMessage ("LanzaBola");
			}
		}
	}

	void SaleFuera() 
	{
		vidas--;
		Barra.SendMessage ("Reinicia");
	}

	public void SumaPuntos()
	{
		puntos += 10;
		puntos_txt.text = puntos + "";
	}

	void  loadLevel(int id)
	{
		SceneManager.LoadScene (id, LoadSceneMode.Additive);
		pantallaCargada = true;
	}
}
