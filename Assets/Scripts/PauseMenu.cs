using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	float localTime;
	public GameObject pauseScreen;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.P) || Input.GetKeyDown (KeyCode.Escape))
		if (Time.timeScale != 0)
			PauseButton ();
		else
			ResumeButton ();
	}

	public void PauseButton()
	{
		localTime = Time.timeScale;
		Time.timeScale = 0;

		pauseScreen.SetActive (true);
	}

	public void ResumeButton()
	{
		Time.timeScale = localTime;

		pauseScreen.SetActive (false);
	}

	public void QuitButton()
	{
		SceneManager.LoadScene ("CreditScene");
	}
}
