using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(KnowledgeOwner))]
public class TestPlayer : MonoBehaviour
{
	private KnowledgeOwner knowledgeOwner;
	public new Camera camera;
	public KnowableObject Tower;

	void Awake()
	{
		knowledgeOwner = GetComponent<KnowledgeOwner>();
	}

	void Update()
	{
		// Move to mouse position
		var targetPosition = camera.ScreenToWorldPoint(Input.mousePosition);
		targetPosition.z = 0;
		transform.position = targetPosition;
	}

	void OnGUI()
	{
		KnowableObject pingThisObj = null;
		GUILayout.BeginVertical();
		GUILayout.Label("Known objects:");
		foreach (var knownObject in knowledgeOwner.KnownObjects)
		{
			GUILayout.BeginHorizontal();
			GUILayout.Label(knownObject.name);
			if (ExecuteEvents.CanHandleEvent<IPingable>(knownObject.gameObject))
			{
				if (GUILayout.Button("Ping"))
				{
					pingThisObj = knownObject;
				}
			}
			GUILayout.EndHorizontal();
		}
		if (knowledgeOwner.KnownObjects.Count == 0)
		{
			GUILayout.Label("- nothing");
		}
		GUILayout.Space(20);
		GUILayout.EndVertical();

		// handle events after rendering UI, to avoid modifying the list
		if (pingThisObj)
		{
			ExecuteEvents.Execute<IPingable>(pingThisObj.gameObject, null, (x, y) => x.OnPing(knowledgeOwner));
		}
	}
}