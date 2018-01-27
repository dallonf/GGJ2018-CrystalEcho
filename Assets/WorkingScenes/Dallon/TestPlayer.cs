using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(KnowledgeOwner))]
public class TestPlayer : MonoBehaviour
{
	private KnowledgeOwner knowledgeOwner;
	public KnowableObject Tower;

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
			GUILayout.Label(knownObject.name);	
		}
		if (knowledgeOwner.KnownObjects.Count == 0) {
			GUILayout.Label("- nothing");
		}
		GUILayout.Space(20);
		if (GUILayout.Button("Ping Tower")) {
			ExecuteEvents.Execute<IPingable>(Tower.gameObject, null, (x, y) => x.OnPing(knowledgeOwner));
		}
		GUILayout.EndVertical();
	}
}