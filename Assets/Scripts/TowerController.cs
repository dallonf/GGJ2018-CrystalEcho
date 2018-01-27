using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour 
{

	public GameObject menuController;

	// Use this for initialization
	void Start () 
	{
		
	}

	public void TowerClicked ()
	{
		if (menuController.activeInHierarchy)
			menuController.SetActive (false);
		else
			menuController.SetActive (true);
	}
	
	public void Button1Pressed()
	{
		//TODO -- stuff when this button is pressed
	}

	public void Button2Pressed()
	{
		//TODO -- stuff when this button is pressed
	}

	public void Button3Pressed()
	{
		//TODO -- stuff when this button is pressed
	}
}
