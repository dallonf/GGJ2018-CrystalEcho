using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class EndGameArea : MonoBehaviour {

	public float FinishRadius = 1f;
	private GameObject trackingPlayer;
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {

		}
	}
}
