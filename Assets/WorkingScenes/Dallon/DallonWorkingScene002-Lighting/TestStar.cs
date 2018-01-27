using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LightSource))]
public class TestStar : MonoBehaviour {

	public float MinTime = 1;
	public float MaxTime = 5;
	public float MinRadius = 1;
	public float MaxRadius = 5;

	public float DecaySpeed = 0.1f;

	private LightSource lightSource;

	private void Awake() {
		lightSource = GetComponent<LightSource>();
	}

	void Start () {
		StartCoroutine(Twinkle());	
	}
	IEnumerator Twinkle() {
		while(true) {
			yield return new WaitForSeconds(Random.Range(MinTime,  MaxTime));
			lightSource.Radius = Random.Range(MinRadius, MaxRadius);
			while  (lightSource.Radius > 0.01) {
				yield return null;
				lightSource.Radius -= DecaySpeed * Time.deltaTime;
			}
			lightSource.Radius = 0;
		}
	}
}
