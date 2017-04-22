using UnityEngine;
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

	private Vector3 moveDirection; 

	void Start() {

		myRigidBody = GetComponent<Rigidbody2D> ();
		//timeBetweenMoveCounter = timeBetweenMove; used for testing only
		//timetoMoveCounter = timetoMove;
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

				moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed, Random.Range (-1f, 1f) * moveSpeed, 0f);
			}
		}

	}

	}

