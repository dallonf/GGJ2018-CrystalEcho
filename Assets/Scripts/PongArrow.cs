using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongArrow : MonoBehaviour
{
	public Transform PointAt;
	public Animator Animator;
	public string DoneState = "done";

	// Update is called once per frame
	void Update()
	{
		var angle = Mathf.Atan2(
			transform.position.y - PointAt.position.y,
			transform.position.x - PointAt.position.x
		) * Mathf.Rad2Deg + 90;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		if (Animator.GetCurrentAnimatorStateInfo(0).IsName(DoneState))
		{
			GameObject.Destroy(gameObject);
		}
	}
}