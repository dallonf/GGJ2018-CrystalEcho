using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(KnowledgeOwner))]
public class TestPingButton : MonoBehaviour
{
	public KnowableObject PingThis;
	private KnowledgeOwner knowledgeOwner;

	void Awake()
	{
		knowledgeOwner = GetComponent<KnowledgeOwner>();
	}

	private void OnGUI()
	{
		if (GUILayout.Button("Ping"))
		{
			ExecuteEvents.Execute<IPingable>(PingThis.gameObject, null, (x, y) => x.Ping(knowledgeOwner));
		}
	}

}