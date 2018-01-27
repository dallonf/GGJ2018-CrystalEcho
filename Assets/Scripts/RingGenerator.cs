using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(LineRenderer))]
public class RingGenerator : MonoBehaviour
{
	public float Radius = 1;
	public int Segments = 8;
	private LineRenderer lineRenderer;

	void Awake()
	{
		lineRenderer = GetComponent<LineRenderer>();
	}

	void Start()
	{
		lineRenderer.positionCount = Segments;
		var positions = new Vector3[lineRenderer.positionCount];
		var fullCircle = Mathf.PI * 2;
		for (int i = 0; i < lineRenderer.positionCount; i++)
		{
			var index = i % Segments;
			var percentOfCircle = (float)index / Segments;
			var radians = fullCircle * percentOfCircle;
			positions[i] = new Vector3(Mathf.Sin(radians), Mathf.Cos(radians), 0);
		}
		lineRenderer.SetPositions(positions);
	}

	void Update()
	{

	}
}