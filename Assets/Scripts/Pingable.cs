using UnityEngine;
using UnityEngine.EventSystems;

public interface IPingable : IEventSystemHandler
{
  void OnPing(KnowledgeOwner source);
}

[RequireComponent(typeof(KnowableObject))]
public class Pingable : MonoBehaviour, IPingable
{
  
  public void OnPing(KnowledgeOwner source)
  {
    throw new System.NotImplementedException();
  }
}