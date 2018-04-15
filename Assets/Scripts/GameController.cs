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
        //Set current level to inactive
		levelsList [currentLevel].gameObject.SetActive (false);

        //Check if final level and either move to next level or loop round to first level
        if (currentLevel < levelsList.Length - 1) {
            currentLevel++;
        } else {
            currentLevel = 0;
        }     	    

        //Set next level to active
		levelsList [currentLevel].gameObject.SetActive (true);
    }
}
