using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class HintTrigger : MonoBehaviour
{
	public KnowledgeOwner KnowledgeOwner;
	public KnowableObject ObjectThatShouldBeKnown;

	public UnityEvent OnNeedsHint;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			if (!KnowledgeOwner.KnownObjects.Contains(ObjectThatShouldBeKnown))
			{
				OnNeedsHint.Invoke();
			}
			// destroy the object so the hint only happens once
			GameObject.Destroy(gameObject);
		}
	}
}