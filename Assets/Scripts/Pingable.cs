using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IPingable : IEventSystemHandler
{
  void OnPing(KnowledgeOwner source);
}

[RequireComponent(typeof(KnowableObject))]
public class Pingable : MonoBehaviour, IPingable
{
  private KnowableObject knowableObject;

  private void Awake()
  {
    knowableObject = GetComponent<KnowableObject>();
  }

  public void OnPing(KnowledgeOwner source)
  {
    var knowledge = new List<KnowableObject>();
    knowledge.Add(knowableObject);
    knowledge.AddRange(knowableObject.Neighbors);
    source.GainKnowledge(knowledge);
    source.ReceivePong(knowableObject);
  }
}