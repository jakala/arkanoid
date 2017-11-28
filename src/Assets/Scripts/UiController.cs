using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour {
	public void LoadCredits()
	{
		SceneManager.LoadScene (2);
		Time.timeScale = 1;
	}

	public void LoadGame()
	{
		SceneManager.LoadScene (1);
		Time.timeScale = 1;
	}

	public void LoadMenu()
	{
		SceneManager.LoadScene (0);
		Time.timeScale = 1;

	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
