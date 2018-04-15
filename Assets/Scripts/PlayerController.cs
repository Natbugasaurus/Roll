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
        //For each point where the ball collides with the level move the particle system and emit some dust
		foreach (ContactPoint contact in collision.contacts) {
			if (!system.isPlaying) {
				crashPart.transform.position = contact.point;
				system.Emit (10);
			}
		}
	}

	void OnCollisionStay(Collision collision) {
        //Jump if ball is colliding with level and space is pressed
		if (Input.GetKeyDown ("space")) {
			rb.AddForce (Vector3.up * thrust);
		}
	}
}
