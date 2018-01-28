using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeListController : MonoBehaviour {

	public Button buttonPefab;
	public RectTransform nodeList;

	// Use this for initialization
	void Start () {
		
	}

	public void AddNodeToList(GameObject node)
	{
		Button newListButton = GameObject.Instantiate (buttonPefab);

	}

}
