using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NodeListElement : MonoBehaviour
{
	public KnowledgeOwner KnowledgeOwner;
	public KnowableObject KnowableObject;
	public Text text;

	public void InitObject(KnowableObject obj)
	{
		KnowableObject = obj;
		text.text = obj.name;
	}

	public void Ping()
	{
		ExecuteEvents.Execute<IPingable>(KnowableObject.gameObject, null, (x, y) => x.Ping(KnowledgeOwner));
	}
}