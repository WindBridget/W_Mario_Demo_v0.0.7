﻿using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {
	public LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "MainCharacter"){
			levelManager.currentCheckPoint = gameObject;
			Debug.Log ("Activated Checkpoint" + transform.position);
		}
	}
}
