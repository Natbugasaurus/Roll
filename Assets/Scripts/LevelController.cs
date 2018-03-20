using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public float rotateSpeed;

    private Vector3 rotateDirection;

    // Use this for initialization
    void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
        rotateDirection = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
        rotateDirection *= rotateSpeed;
        transform.Rotate(rotateDirection);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, 0.025f);
    }
}
