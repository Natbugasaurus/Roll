using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject[] levelsList;
    public int currentLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void NextLevel () {
		levelsList [currentLevel].gameObject.SetActive (false);
        if (currentLevel < levelsList.Length - 1) {
            currentLevel++;
        } else {
            currentLevel = 0;
        }     	    
		levelsList [currentLevel].gameObject.SetActive (true);
    }
}
