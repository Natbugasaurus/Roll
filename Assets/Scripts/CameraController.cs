using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	private Vector3 offset;
    public Transform target;
    public float rotateSpeed;
	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position + offset;
        transform.LookAt(target);

        if (Input.GetMouseButton(0))
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotateSpeed, Vector3.up);

            offset = camTurnAngle * offset;
        }
	}
}
