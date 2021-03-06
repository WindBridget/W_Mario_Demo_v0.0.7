﻿using UnityEngine;
using System.Collections;

public class HurtEnemyOnContact : MonoBehaviour {

	public int damegaToGive;
	public float bounceOnEnemy;
	private Rigidbody2D myRigidbody2D;
	// Use this for initialization
	void Start () {
		myRigidbody2D = transform.parent.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy") {
			other.GetComponent<EnemyHealthManager>().giveDamage(damegaToGive);
			myRigidbody2D.velocity = new Vector2 (myRigidbody2D.velocity.x, bounceOnEnemy);
		}

	}
}
