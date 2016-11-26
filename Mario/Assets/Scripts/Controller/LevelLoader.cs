﻿using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	private bool playerInZone;
	public string levelToLoad;
	// Use this for initialization
	void Start () {
		playerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerInZone) {
			Application.LoadLevel(levelToLoad);	
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "MainCharacter") {
			playerInZone = true;		
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.name == "MainCharacter") {
			playerInZone = false;		
		}
	}
}
