using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour {
	public Transform level;
	public GameController gameController;

	void start () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
            //Reset player position
			other.transform.position = new Vector3(0,0,0);
            //Reset world rotation
			level.transform.rotation = Quaternion.identity;
            //Reset velocity
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            //Move to next level
            gameController.NextLevel ();
		}
	}
}
