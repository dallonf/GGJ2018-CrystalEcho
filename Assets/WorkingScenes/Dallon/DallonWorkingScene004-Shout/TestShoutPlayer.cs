using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(KnowledgeOwner))]
public class TestShoutPlayer : MonoBehaviour
{
	private KnowledgeOwner knowledgeOwner;

	void Awake()
	{
		knowledgeOwner = GetComponent<KnowledgeOwner>();
	}

	void OnGUI()
	{
		GUILayout.BeginVertical();
		GUILayout.Label("Known objects:");
		foreach (var knownObject in knowledgeOwner.KnownObjects)
		{
			GUILayout.BeginHorizontal();
			GUILayout.Label(knownObject.name);
			GUILayout.EndHorizontal();
		}
		if (knowledgeOwner.KnownObjects.Count == 0)
		{
			GUILayout.Label("- nothing");
		}
		GUILayout.Space(20);
		GUILayout.EndVertical();
	}
}