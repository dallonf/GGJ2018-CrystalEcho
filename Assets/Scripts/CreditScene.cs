﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScene : MonoBehaviour {

	public void TitleButton(){ SceneManager.LoadScene ("MainMenuScene"); }

	public void QuitButton(){ Application.Quit (); }
}
