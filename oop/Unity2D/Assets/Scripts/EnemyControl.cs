﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyControl : MonoBehaviour {

	public float moveSpeed;

	private Rigidbody2D myRigidBody; //rigidbody component 

	private bool moving;

	public float timeBetweenMove;//how long the enemies stay still while not moving
	private float timeBetweenMoveCounter;
	public float timetoMove; //how long the enemies move for 
	private float timetoMoveCounter;

	private Vector3 moveDirection; //in the direction the enemy is moving this uses a vector

	void Start() {

		myRigidBody = GetComponent<Rigidbody2D> ();
		//timeBetweenMoveCounter = timeBetweenMove; used for testing only
		//timetoMoveCounter = timetoMove;
		//these are used to randomly move the slimes so that they are not moving in the same direction all the time 
		timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
		timetoMoveCounter = Random.Range (timetoMove * 0.75f, timeBetweenMove * 1.25f); 
	}

	void Update() {

		if (moving) {

			timetoMoveCounter -= Time.deltaTime;
			myRigidBody.velocity = moveDirection;

			if (timetoMoveCounter < 0f) {

				moving = false;
				//timeBetweenMoveCounter = timeBetweenMove;
				timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
			}

		} else {

			timeBetweenMoveCounter -= Time.deltaTime; //length of time it takes one update of the screen
			myRigidBody.velocity = Vector2.zero;
			if (timeBetweenMoveCounter < 0f) {

				moving = true;
				//timetoMoveCounter = timetoMove;
				timetoMoveCounter = Random.Range (timetoMove * 0.75f, timeBetweenMove * 1.25f); 
				//used to randomly generate the direction the enemies move in 
				moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed, Random.Range (-1f, 1f) * moveSpeed, 0f); //multiplying the random number by movespeed, to make
				//the enemy move at a varying speed
			}
		}

	}

	}

