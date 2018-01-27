using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(KnowledgeOwner))]
public class Shouts : MonoBehaviour
{
  private KnowledgeOwner knowledgeOwner;
  public GameObject ShoutEffect;
  public float Range = 10;
  public float ShoutEffectNaturalRadius = 10;

  void Awake()
  {
    knowledgeOwner = GetComponent<KnowledgeOwner>();
  }

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
  }
}