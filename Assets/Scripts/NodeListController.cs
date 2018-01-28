using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeListController : MonoBehaviour
{
	public KnowledgeOwner KnowledgeOwner;
	public NodeListElement ElementPrefab;
	public RectTransform ElementList;

	private Dictionary<KnowableObject, NodeListElement> elementMap = new Dictionary<KnowableObject, NodeListElement>();

	void Update()
	{
		foreach (var knownObj in KnowledgeOwner.KnownObjects)
		{
			if (!elementMap.ContainsKey(knownObj))
			{
				AddNodeToList(knownObj);
			}
		}
	}

	public void AddNodeToList(KnowableObject node)
	{
		NodeListElement newListElement = GameObject.Instantiate(ElementPrefab);
		newListElement.GetComponent<RectTransform>().SetParent(ElementList, false);
		newListElement.KnowledgeOwner = KnowledgeOwner;
		newListElement.InitObject(node);
		elementMap.Add(node, newListElement);
	}

}