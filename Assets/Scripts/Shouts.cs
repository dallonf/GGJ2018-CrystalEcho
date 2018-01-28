using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Shouts : MonoBehaviour
{
  public KnowledgeOwner knowledgeOwner;
  public GameObject ShoutEffect;
  public float Range = 10;
  public float ShoutEffectNaturalRadius = 10;
  public UnityEvent Onshout;

  public void Shout()
  {
    var effect = GameObject.Instantiate(ShoutEffect, transform.position, Quaternion.identity);
    effect.transform.localScale = Vector3.one * Range / ShoutEffectNaturalRadius;

    // get all knowables in the scene, check which ones are in range, and send
    // the shout event
    var knowables = FindObjectsOfType<KnowableObject>()
      .Where(k => Vector3.Distance(k.transform.position, transform.position) < Range);

    foreach (var obj in knowables)
    {
      ExecuteEvents.Execute<IRespondsToShout>(
        obj.gameObject,
        null,
        (x, y) => x.ReceiveShout(knowledgeOwner)
      );
    }
		Onshout.Invoke();
  }
}