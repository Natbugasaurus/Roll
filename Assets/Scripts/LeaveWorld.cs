using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveWorld : MonoBehaviour {

	//public GameObject player;
	public Transform level;

	void start () {

	}

	void OnTriggerExit(Collider other) {
		other.transform.position = new Vector3(0,0,0);
		level.transform.rotation =  Quaternion.identity;
	}
}
