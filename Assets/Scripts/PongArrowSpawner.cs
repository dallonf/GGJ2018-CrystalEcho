using UnityEngine;

public class PongArrowSpawner : MonoBehaviour {
  public PongArrow Prefab;
  public void SpawnPongArrow(KnowableObject obj) {
    var instance = GameObject.Instantiate(Prefab, transform.position, Quaternion.identity);
    instance.transform.parent = transform;
    instance.GetComponent<PongArrow>().PointAt = obj.transform;
  }
}