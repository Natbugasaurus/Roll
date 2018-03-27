using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public float rotateSpeed;

    private Vector3 rotateDirection;

    void Start () {

	}
		
	void FixedUpdate () {
        rotateDirection = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
		rotateDirection *= rotateSpeed;
		rotateDirection = Camera.main.transform.rotation * rotateDirection;

		//transform.rotation = Quaternion.AngleAxis (transform.rotation.z, Camera.main.transform.right);
        transform.Rotate(rotateDirection);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, 0.015f);
    }
}
