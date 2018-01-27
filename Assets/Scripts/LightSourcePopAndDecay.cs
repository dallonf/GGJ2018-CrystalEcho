using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LightSource))]
public class LightSourcePopAndDecay : MonoBehaviour
{
	private LightSource lightSource;
	public LightPopConfig Config;

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
			lightSource.Radius = Mathf.Lerp(0, Config.Radius, currentTime / Config.DecayTime);
		}
		else if (currentTime < 0)
		{
			lightSource.Radius = 0;
			currentTime = 0;
		}
	}

	public void Pop()
	{
		currentTime = Config.DecayTime;
	}
}