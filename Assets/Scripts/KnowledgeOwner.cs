using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KnowledgeOwner : MonoBehaviour
{

	[System.Serializable]
	public class PongEvent : UnityEvent<KnowableObject> { }
	public List<KnowableObject> KnownObjects;

	public PongEvent OnReceivePong;

	public void GainKnowledge(IEnumerable<KnowableObject> objects)
	{
		foreach (var obj in objects)
		{
			if (!KnownObjects.Contains(obj))
			{
				KnownObjects.Add(obj);
			}
		}
	}

	public void ReceivePong(KnowableObject source)
	{
		OnReceivePong.Invoke(source);
	}
}