using UnityEngine;
using UnityEngine.Events;

public class TriggerEventOnce : MonoBehaviour
{
  public UnityEvent Event;
  public bool HasBeenTriggered = false;

  public void Trigger()
  {
    if (!HasBeenTriggered)
    {
      Event.Invoke();
      HasBeenTriggered = true;
    }
  }
}