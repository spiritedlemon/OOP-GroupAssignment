using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementConfined : MonoBehaviour {
	
	public float moveSpeed;	//Speed they move at
	
	private Rigidbody2D rb;
	
	public bool isWalking;
	
	public float walkTime;		//Time to spend walking
	public float walkCounter; 
	public float waitTime;		//Time to spend waiting
	public float waitCounter;
	
	private int walkDirection;
	
	
	//Lock them in an area
	public Collider2D walkZone;
	private bool hasWalkZone = false;
	
	private Vector2 minWalkPoint;
	private Vector2 maxWalkPoint;
	

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D>();
		
		//adds more vaiance to movement
		waitTime = Random.Range (waitTime * 0.75f, waitTime * 1.25f);
		walkTime = Random.Range (walkTime * 0.75f, walkTime * 1.25f); 
		
		waitCounter = waitTime; 
		walkCounter = walkTime;
		
		ChooseDirection();
		
		if(walkZone != null)
		{
			minWalkPoint = walkZone.bounds.min;
			maxWalkPoint = walkZone.bounds.max;
			hasWalkZone = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isWalking == true)
		{
			walkCounter -= Time.deltaTime; //Ticks down counter
			
			
			
			//Switch statement to define what directions do
			switch(walkDirection)
			{
				case 0:
				{
					
					if( (hasWalkZone == true) && (transform.position.y > maxWalkPoint.y) ) //If npc cannot go that direction
					{
						isWalking = false;
						waitCounter = waitTime;
					}
					else
					{
						rb.velocity = new Vector2(0, moveSpeed); //y value inreases by Movespeed - Up
					}

					break;
				}
				
				case 1:
				{
					
					if( (hasWalkZone == true) && (transform.position.x > maxWalkPoint.x) ) //If npc cannot go that direction
					{
						isWalking = false;
						waitCounter = waitTime;
					}
					else
					{
						rb.velocity = new Vector2(moveSpeed, 0); //x value increases - Right
					}

					break;
				}
				
				case 2:
				{
					
					if( (hasWalkZone == true) && (transform.position.y < minWalkPoint.y) ) //If npc cannot go that direction
					{
						isWalking = false;
						waitCounter = waitTime;
					}
					else
					{
						rb.velocity = new Vector2(0, -moveSpeed); //y value decreases - Down
					}
					
					break;
				}
				
				case 3:
				{
					
					if( (hasWalkZone == true) && (transform.position.x < minWalkPoint.x) ) //If npc cannot go that direction
					{
						isWalking = false;
						waitCounter = waitTime;
					}
					else
					{
						rb.velocity = new Vector2(-moveSpeed, 0); //x value decreases - Left
					}
					
					break;
				}
				
			}//end switch
			
			if(walkCounter < 0)
			{
				isWalking = false;
				waitCounter = Random.Range (waitTime * 0.75f, waitTime * 1.25f);
			}
			
		}
		else
		{
			//counter measuring time left until move ticks down
			waitCounter -= Time.deltaTime;
			rb.velocity = Vector2.zero;
			
			if(waitCounter < 0)
			{
				ChooseDirection();
			}
			
		}
		
		
	}
	
	
	public void ChooseDirection()
	{
		walkDirection = Random.Range (0,4); //Choose random direction - 0,1,2,3
		isWalking = true;
		walkCounter = walkTime;
		
	}
	
}
