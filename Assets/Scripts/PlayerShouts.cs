using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Shouts))]
public class PlayerShouts : MonoBehaviour, IPointerClickHandler
{
  Shouts shouts;
  void Awake()
  {
    shouts = GetComponent<Shouts>();
  }

  public void OnPointerClick(PointerEventData eventData)
  {
    shouts.Shout();
  }
}