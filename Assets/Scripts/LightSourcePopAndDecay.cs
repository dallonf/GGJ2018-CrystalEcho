using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LightSource))]
public class LightSourcePopAndDecay : MonoBehaviour
{
	private LightSource lightSource;
	public float TimeToDecay = 3;
	public float Radius;

	private float currentTime = 0;

	void Awake()
	{
		lightSource = GetComponent<LightSource>();
	}

	void Update()
	{
		if (currentTime > 0)
		{
			currentTime -= Time.deltaTime;
			lightSource.Radius = Mathf.Lerp(0, Radius, currentTime / TimeToDecay);
		}
		else if (currentTime < 0)
		{
			lightSource.Radius = 0;
			currentTime = 0;
		}
	}

	public void Pop()
	{
		currentTime = TimeToDecay;
	}
}