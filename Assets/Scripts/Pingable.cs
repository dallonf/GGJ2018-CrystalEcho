using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public interface IPingable : IEventSystemHandler

{
  void Ping(KnowledgeOwner source);
}

[RequireComponent(typeof(KnowableObject))]
public class Pingable : MonoBehaviour, IPingable

{
  [System.Serializable]
  public class PingEvent : UnityEvent<KnowledgeOwner> { }
  private KnowableObject knowableObject;
  public PingEvent OnPing;


  private void Awake()
  {
    knowableObject = GetComponent<KnowableObject>();
  }

  public void Ping(KnowledgeOwner source)
  {
    OnPing.Invoke(source);
    source.ReceivePong(knowableObject);

  }
}


