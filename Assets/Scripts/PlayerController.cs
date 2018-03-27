using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject crashPart;
	public ParticleSystem system;
	public Rigidbody rb;

	public int thrust;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		foreach (ContactPoint contact in collision.contacts) {
			if (!system.isPlaying) {
				crashPart.transform.position = contact.point;
				system.Emit (10);
			}
		}
	}

	void OnCollisionStay(Collision collision) {
		if (Input.GetKeyDown ("space")) {
			rb.AddForce (Vector3.up * thrust);
		}
	}
}
