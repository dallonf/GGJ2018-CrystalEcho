using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {

	float speed = 2.0f;

	Vector3 movement;

	void Start () 
	{
		movement = new Vector3 ();
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;

//			movement.y += Input.GetAxisRaw ("Vertical");
			movement += Vector3.up;

		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
			movement += Vector3.left;
		}

		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
			movement += Vector3.down;
		}

		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
			movement += Vector3.right;
		}

		movement = movement.normalized;

		var angle = Mathf.Atan2(
			movement.y,
			movement.x
		) * Mathf.Rad2Deg - 90;
//		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), speed / 20);
	}
}
