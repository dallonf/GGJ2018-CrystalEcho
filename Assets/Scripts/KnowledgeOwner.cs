using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KnowledgeOwner : MonoBehaviour
{
	[System.Serializable]
	public class PongEvent : UnityEvent<KnowableObject> { }
	[System.Serializable]
	public class DiscoveredObjectEvent : UnityEvent<KnowableObject> { }
	public List<KnowableObject> KnownObjects;

	public PongEvent OnReceivePong;
	public DiscoveredObjectEvent OnDiscoveredObject;

	public void GainKnowledge(IEnumerable<KnowableObject> objects)
	{
		foreach (var obj in objects)
		{
			GainKnowledge(obj);
		}
	}

	public void GainKnowledge(KnowableObject obj)
	{
		if (!KnownObjects.Contains(obj))
		{
			KnownObjects.Add(obj);
			OnDiscoveredObject.Invoke(obj);
		}
	}

	public void ReceivePong(KnowableObject source)
	{
		OnReceivePong.Invoke(source);
	}
}