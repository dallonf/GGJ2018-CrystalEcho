using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IRespondsToShout : IEventSystemHandler
{
  void ReceiveShout(KnowledgeOwner source);
}

[RequireComponent(typeof(KnowableObject))]
public class RespondsToShout : MonoBehaviour, IRespondsToShout
{
  [System.Serializable]
  public class ShoutEvent : UnityEvent<KnowledgeOwner> { }
  private KnowableObject knowableObject;
  public ShoutEvent OnShout;

  private void Awake()
  {
    knowableObject = GetComponent<KnowableObject>();
  }
  public void ReceiveShout(KnowledgeOwner source)
  {
    source.GainKnowledge(knowableObject);
    OnShout.Invoke(source);
  }
}