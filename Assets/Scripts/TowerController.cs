using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerController : MonoBehaviour 
{
	public GameObject menuController;

	// Use this for initialization
	void Start () 
	{
		
	}

    IEnumerator MenuKillTimer()
    {
        yield return new WaitForSeconds(4.0f);

        if (menuController.activeInHierarchy)
            menuController.SetActive(false);
    }

	public void TowerClicked ()
	{
		if (menuController.activeInHierarchy)
        {
            menuController.SetActive(false);
            StopCoroutine(MenuKillTimer());
        }

		else
        {
            menuController.SetActive(true);
            StartCoroutine(MenuKillTimer());
        }
	}
	
	public void Button1Pressed()
	{
        StopCoroutine(MenuKillTimer());
        menuController.SetActive(false);
        //TODO -- stuff when this button is pressed
    }

	public void Button2Pressed()
	{
        StopCoroutine(MenuKillTimer());
        menuController.SetActive(false);
        //TODO -- stuff when this button is pressed
    }

	public void Button3Pressed()
	{
        StopCoroutine(MenuKillTimer());
        menuController.SetActive(false);
        //TODO -- stuff when this button is pressed
    }
}
