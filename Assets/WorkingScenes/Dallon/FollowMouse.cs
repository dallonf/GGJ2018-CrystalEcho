using UnityEngine;

public class FollowMouse : MonoBehaviour
{
  public new Camera camera;
  void Update()
  {
    // Move to mouse position
    var targetPosition = camera.ScreenToWorldPoint(Input.mousePosition);
    targetPosition.z = 0;
    transform.position = targetPosition;
  }
}