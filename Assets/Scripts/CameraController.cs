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
        //Set offset based on distance from camera to player
		offset = transform.position - target.transform.position;
	}
		
	void Update () {
        //Get x and y mouse movement
		x += Input.GetAxis ("Mouse X") * rotateSpeed;

		if (invertY) {
			y += Input.GetAxis ("Mouse Y") * rotateSpeed;
		} else {
			y -= Input.GetAxis ("Mouse Y") * rotateSpeed;
		}
        
        //Clamp y movement
		y = Mathf.Clamp (y, yMin, yMax);

        //Create Quaternion using x and y values
		Quaternion rotation = Quaternion.Euler (y, x, 0);

        //Apply rotation to camera
		transform.rotation = rotation;
        
        //Move camera position based on rotation to create orbit effect 
		transform.position = Vector3.Lerp(transform.position, rotation * offset + target.transform.position, 0.08f);

        //Always have camera facing player
        transform.LookAt(target);

        //Bad invert Y code
		if (Input.GetKeyDown(KeyCode.Y)) {
			invertY = !invertY;
		}
	}
}
