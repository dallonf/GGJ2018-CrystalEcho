using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSource : MonoBehaviour
{
	public SpriteRenderer LightmaskPrefab;
	public float Radius = 0;
	public float Opacity = 1;

	private SpriteRenderer lightmask;

	// Use this for initialization
	void Start()
	{
		lightmask = GameObject.Instantiate(
			LightmaskPrefab,
			transform.position,
			Quaternion.identity
		).GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		lightmask.transform.localScale = Vector3.one * Radius;
		lightmask.color = new Color(1, 1, 1, Opacity);
	}
}