using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(LineRenderer))]
public class RingGenerator : MonoBehaviour
{
	public float Radius = 1;
	public int Segments = 8;
	public float Alpha = 1;
	private LineRenderer lineRenderer;

	private float lastRadius;
	private float lastSegments;

	void Awake()
	{
		lineRenderer = GetComponent<LineRenderer>();
	}

	void Start()
	{
		GeneratePoints();
	}

	void Update()
	{
		if (Radius != lastRadius || Segments != lastSegments)
		{
			GeneratePoints();
		}
		UpdateAlpha();
	}

	private void UpdateAlpha()
	{
		if(!Application.isPlaying) return;
		Color currentColor = lineRenderer.material.color;
		currentColor.a = Alpha;
		lineRenderer.material.color = currentColor;
	}

	private void GeneratePoints()
	{
		lineRenderer.positionCount = Segments + 1;
		float x;
		float y;
		float z = 0f;

		float angle = 20f;

		for (int i = 0; i < (Segments + 1); i++)
		{
			x = Mathf.Sin(Mathf.Deg2Rad * angle) * Radius;
			y = Mathf.Cos(Mathf.Deg2Rad * angle) * Radius;

			lineRenderer.SetPosition(i, new Vector3(x, y, z));

			angle += (360f / Segments);
		}

		lastRadius = Radius;
		lastSegments = Segments;
	}
}