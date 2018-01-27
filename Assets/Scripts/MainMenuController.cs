using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public GameObject controlsBackground;
	public GameObject creditsBackground;
	public GameObject quitBackground;

	// Use this for initialization
	void Start () 
	{
		
	}

	public void StartButton()
	{
		SceneManager.LoadScene("GameScene");
	}

	public void ControlsButton()
	{
		controlsBackground.SetActive (true);
	}

	public void CreditsButton()
	{
		creditsBackground.SetActive (true);
	}

	public void QuitButton()
	{
		quitBackground.SetActive (true);
	}

	public void ControlsBackButton ()
	{
		controlsBackground.SetActive (false);
	}

	public void CreditsBackButton ()
	{
		creditsBackground.SetActive (false);
	}

	public void QuitNoButton ()
	{
		quitBackground.SetActive (false);
	}

	public void QuitYesButton ()
	{
		Application.Quit ();
	}
}
