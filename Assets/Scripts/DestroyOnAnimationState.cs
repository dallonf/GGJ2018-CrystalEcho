using UnityEngine;

public class DestroyOnAnimationState : MonoBehaviour
{
  public Animator Animator;
  public string DoneState = "done";
  private void Update()
  {
    if (Animator.GetCurrentAnimatorStateInfo(0).IsName(DoneState))
    {
      GameObject.Destroy(gameObject);
    }
  }
}