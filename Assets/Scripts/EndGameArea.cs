using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class EndGameArea : MonoBehaviour
{

	public float FinishRadius = 1f;
	public float StartRadius = 40;
	public CanvasGroup FadeToWhite;
	private GameObject trackingPlayer;

	public UnityEvent OnEndGame;

	// Update is called once per frame
	void Update()
	{
		if (trackingPlayer)
		{
			var distance = Vector3.Distance(trackingPlayer.transform.position, transform.position);
			float percent = Mathf.InverseLerp(StartRadius, FinishRadius, distance);
			FadeToWhite.alpha = percent;

			if (percent >= 1 - Mathf.Epsilon) {
				OnEndGame.Invoke();
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			trackingPlayer = other.gameObject;
			FadeToWhite.gameObject.SetActive(true);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject == trackingPlayer)
		{
			trackingPlayer = null;
			FadeToWhite.gameObject.SetActive(false);
		}
	}
}