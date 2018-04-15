using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveWorld : MonoBehaviour {

    public GameObject player;
	public Transform level; 

	void start () {

	}

	void OnTriggerExit(Collider other) {
        //When player falls out of the play area, reset their position and velocity plus the level's rotation
		other.transform.position = new Vector3(0,0,0);
		level.transform.rotation =  Quaternion.identity;
        other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
