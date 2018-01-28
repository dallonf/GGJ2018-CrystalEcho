using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrologueController : MonoBehaviour {

	public GameObject TextPrefab;
	public GameObject skipbutton;
	public PrologueText[] textFabList;
	public ScrollRect ScrollRect;
	public RectTransform ContentGroup;
	public float CharTime = 0.1f;

	void Start()
	{
		StartCoroutine(ShowText ());
		StartCoroutine (SkipButton ());
	}

	void Update(){

		if (Input.anyKey && skipbutton.activeInHierarchy)
			ContinueButton ();
	}

	IEnumerator ShowText()
	{
		for(int i = 0; i < textFabList.Length; i++) 
		{
			string newMessage = textFabList[i].proText;
			var newTextObject = GameObject.Instantiate(TextPrefab).GetComponent<Text>();
			RectTransform newTransform = newTextObject.GetComponent<RectTransform>();
			newTransform.SetParent(ContentGroup, false);
//			Color textColor = textFabList [i].myColor;
//			textColor.a = 255.0f;
//			newTextObject.GetComponent<Text>().color = textColor;
			newTextObject.GetComponent<Text>().color = textFabList [i].myColor;

//			Debug.Log ("Inside i for loop and i = " + i + ". newMessage = " + newMessage.ToString ());

			for (int j = 1; j < newMessage.Length + 1; j++)
			{
				newTextObject.GetComponent<Text>().text = newMessage.Substring(0, j);

//				Debug.Log ("Inside j for loop and j = " + j + ". newTextObject.text = " + newTextObject.GetComponent<Text>().text.ToString ());

				// Scroll to bottom
				ScrollRect.StopMovement();
				ScrollRect.verticalNormalizedPosition = 0;

				yield return new WaitForSeconds(CharTime);
			}
		}
	}

	IEnumerator SkipButton(){

		yield return new WaitForSeconds(5f);

		skipbutton.SetActive (true);


	}

	public void ContinueButton(){

		SceneManager.LoadScene ("GameScene");
	}
}
