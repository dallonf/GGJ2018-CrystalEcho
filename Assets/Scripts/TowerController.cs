using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(KnowableObject))]
public class TowerController : MonoBehaviour 
{
    private KnowableObject knowableObject;
	public GameObject menuController;
    public Text text;
    public KnowledgeOwner KnowledgeOwner;

    private bool hasBeenDiscovered = false;

	void Awake() 
	{
        // HACK: I don't really want to configure the KnowledgeOwner
        // on all these towers, so try to find it
        if (!KnowledgeOwner)  
        {
            KnowledgeOwner = FindObjectOfType<KnowledgeOwner>();
        }
        knowableObject = GetComponent<KnowableObject>();
	}

    void Start() 
    {
        KnowledgeOwner.OnDiscoveredObject.AddListener(OnKnowledgeOwnerDiscoveredObj);
    }

    void OnKnowledgeOwnerDiscoveredObj(KnowableObject discoveredObj) 
    {
        if (discoveredObj == knowableObject)
        {
            text.text = name;
            text.gameObject.SetActive(true);
            hasBeenDiscovered = true;
        }
    }

    IEnumerator MenuKillTimer()
    {
        yield return new WaitForSeconds(4.0f);

        if (menuController.activeInHierarchy)
            menuController.SetActive(false);
    }

	public void TowerClicked ()
	{
        if  (!hasBeenDiscovered) return;
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
