using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
	public Transform target;
    public float rotateSpeed;
	float x = 0.0f;
	float y = 0.0f;

	public float yMin, yMax;

	public bool invertY;

	private Vector3 offset;

	void Start () {
		offset = transform.position - target.transform.position;
	}
		
	void Update () {
        //if (Input.GetMouseButton(0)) {
			x += Input.GetAxis ("Mouse X") * rotateSpeed;
			y -= Input.GetAxis ("Mouse Y") * rotateSpeed;
        //}

		y = Mathf.Clamp (y, yMin, yMax);

		Quaternion rotation = Quaternion.Euler (y, x, 0);
		transform.rotation = rotation;

		transform.position = rotation * offset + target.transform.position ;
		transform.LookAt(target);
	}
}
