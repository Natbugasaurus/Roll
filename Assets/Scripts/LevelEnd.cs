﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour {
	public Transform level;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.transform.position = new Vector3(0,0,0);
			level.transform.rotation =  Quaternion.identity;
		}
	}
}