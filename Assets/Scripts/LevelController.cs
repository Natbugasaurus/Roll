using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public float rotateSpeed;

    private Vector3 rotateDirection;

    void Start () {

	}
		
	void FixedUpdate () {
        //Get rotation from arrow keys
        rotateDirection = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));

        //Apply rotation speed
		rotateDirection *= rotateSpeed;

        //Adjust rotation based on camera position
		rotateDirection = Camera.main.transform.rotation * rotateDirection;

        //Apply rotation to level
        transform.Rotate(rotateDirection);

        //Lerp back to original position
        //Also serves as a clamp when lerp amount becomes greater than rotation speed
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, 0.015f);
    }
}
