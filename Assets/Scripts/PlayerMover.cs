using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour 
{
	private Rigidbody rigidbody;
	public float speed = 2.0f;

	private void Awake() 
	{
		rigidbody = GetComponent<Rigidbody>();	
	}

	void Start () 
	{
	}

	void Update ()
	{
		Vector3 movement = Vector3.zero;
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow))
		{
			// transform.position += Vector3.up * speed * Time.deltaTime;
			movement += Vector3.up;
		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			// transform.position += Vector3.left * speed * Time.deltaTime;
			movement += Vector3.left;
		}

		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) 
		{
			// transform.position += Vector3.down * speed * Time.deltaTime;
			movement += Vector3.down;
		}

		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			// transform.position += Vector3.right * speed * Time.deltaTime;
			movement += Vector3.right;
		}
		movement.Normalize();

		if (movement.magnitude > Mathf.Epsilon) {
			rigidbody.velocity = movement * speed;
		}

		var angle = Mathf.Atan2(
			movement.y,
			movement.x
		) * Mathf.Rad2Deg - 90;

		transform.rotation = Quaternion.Slerp (
			transform.rotation,
			Quaternion.AngleAxis(angle, Vector3.forward),
			speed / 20
		);
	}
}
