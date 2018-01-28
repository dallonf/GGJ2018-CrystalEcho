using UnityEngine;

public class FollowMouse : MonoBehaviour
{
  public new Camera camera;
  public float z;
  void Update()
  {
    if (camera.orthographic)
    {
      var targetPosition = camera.ScreenToWorldPoint(Input.mousePosition);
      targetPosition.z = z;
      transform.position = targetPosition;
    }
    else
    {
      var ray = camera.ScreenPointToRay(Input.mousePosition);
      var plane = new Plane(Vector3.forward, new Vector3(0, 0, z));
      float distance;
      if (plane.Raycast(ray, out distance))
      {
        var targetPosition = ray.GetPoint(distance);
        transform.position = targetPosition;
      }
    }
  }
}