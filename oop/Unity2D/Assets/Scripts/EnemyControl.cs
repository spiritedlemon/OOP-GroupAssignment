using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyControl : MonoBehaviour {

	public float moveSpeed;

	private Rigidbody2D myRigidBody; //rigidbody component 

	private bool moving;

	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	public float timetoMove;
	private float timetoMoveCounter;

	private Vector3 moveDirection; 

	void Start() {

		myRigidBody = GetComponent<Rigidbody2D> ();
		timeBetweenMoveCounter = timeBetweenMove;
		timetoMoveCounter = timetoMove;

	}

	void Update() {

		if (moving) {

			timetoMoveCounter -= Time.deltaTime;
			myRigidBody.velocity = moveDirection;

			if (timetoMoveCounter < 0f) {

				moving = false;
				timeBetweenMoveCounter = timeBetweenMove;
			}

		} else {

			timeBetweenMoveCounter -= Time.deltaTime; //length of time it takes one update of the screen
			myRigidBody.velocity = Vector2.zero;
			if (timeBetweenMoveCounter < 0f) {

				moving = true;
				timetoMoveCounter = timetoMove;

				moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed, Random.Range (-1f, 1f) * moveSpeed, 0f);
			}
		}

	}

	}

