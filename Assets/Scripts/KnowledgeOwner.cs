using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowledgeOwner : MonoBehaviour
{
	public List<KnowableObject> KnownObjects;

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
}