using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLighting : MonoBehaviour
{

	public LightSourcePopAndDecay[] Fingers;
	public float MeidanSpeed = 10;
	public float Variance;

	public void LightFingers()
	{
		foreach (var finger in Fingers)
		{
			StartCoroutine(LightUpSingleFinger(finger));
		}
	}

	private IEnumerator LightUpSingleFinger(LightSourcePopAndDecay finger)
	{
		var distance = Vector3.Distance(finger.transform.position, transform.position);
		var time = distance / MeidanSpeed;
		time += Random.Range(-Variance, Variance);
		if (time < 0) time = 0;
		yield return new WaitForSeconds(time);
		finger.Pop();
	}
}