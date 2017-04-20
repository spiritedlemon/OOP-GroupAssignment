using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemControl : MonoBehaviour {

	//variables 
	public float movespeed;
	private Rigidbody2D myrigidbody;
	private bool moving;
	public float timeofmove;
	private float timeofmove_counter;
	public float timetomove;
	private float timetomove_counter;
	private Vector3 movedirection; 
	// Use this for initialization
	void Start () 
	{
		myrigidbody = GetComponent<Rigidbody2D> ();

		timeofmove_counter = timeofmove;
		timetomove_counter = timetomove;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (moving) 
		{
			timetomove_counter -= Time.deltaTime;
			myrigidbody.velocity = movedirection;
			if (timetomove_counter < 0f) 
			{
				moving = false;
				timeofmove_counter = timeofmove;
			}

		} else 
		{
			timeofmove_counter += Time.deltaTime; //updating the screen
			//in between each move
			myrigidbody.velocity = Vector2.zero; //not moving golmen anywhere
			if (timeofmove_counter < 0f) 
			{
				moving = true;
				timetomove_counter = timetomove;
				movedirection = new Vector3 (Random.Range (-1f, 1f) * movespeed, Random.Range(-1f,1f) * movespeed,(0f));
			}
		}
	}
}
