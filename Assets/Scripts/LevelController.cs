using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public float rotateSpeed;

	private Quaternion rotation = Quaternion.Euler(0,0,0);

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 rotateDirection = new Vector3(Input.GetAxis("Vertical"),0,Input.GetAxis("Horizontal"));
		rotateDirection *= rotateSpeed;
		transform.Rotate(rotateDirection);

		transform.rotation = Quaternion.Slerp();
	}
}
