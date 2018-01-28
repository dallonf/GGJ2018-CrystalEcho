using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(KnowledgeOwner))]
[RequireComponent(typeof(Shouts))]
public class TestShoutPlayer : MonoBehaviour
{
	private KnowledgeOwner knowledgeOwner;
	private Shouts shouts;

	void Awake()
	{
		knowledgeOwner = GetComponent<KnowledgeOwner>();
		shouts = GetComponent<Shouts>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			shouts.Shout();
		}
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
		GUILayout.Label("Press space to Shout");
		GUILayout.EndVertical();
	}
}