using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour {
	
	public float moveSpeed;	//Speed they move at
	
	private Rigidbody2D rb;
	
	public bool isWalking;
	
	public float walkTime;		//Time to spend walking
	public float walkCounter; 
	public float waitTime;		//Time to spend waiting
	public float waitCounter;
	
	private int walkDirection;
	
	private Animator anim;
	
	//Lock them in an area
	public Collider2D walkZone;
	private bool hasWalkZone = false;
	private Vector2 minWalkPoint;
	private Vector2 maxWalkPoint;
	

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
		
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
			anim.SetBool("GolWalk", true);
			walkCounter -= Time.deltaTime; //Ticks down counter
			
			
			
			//Switch statement to define what directions do
			switch(walkDirection)
			{
				case 0:
				{
					rb.velocity = new Vector2(0, moveSpeed); //y value inreases by Movespeed - Up
					
					if( (hasWalkZone == true) && (transform.position.y > maxWalkPoint.y) ) //If npc cannot go that direction
					{
						isWalking = false;
						anim.SetBool("GolWalk", false);
						waitCounter = waitTime;
					}
					else //If they can go
					{
						anim.SetFloat ("inputX", 0);
						anim.SetFloat ("inputY", 1);
					}
					
					break;
				}
				
				case 1:
				{
					rb.velocity = new Vector2(moveSpeed, 0); //x value increases - Right
					
					if( (hasWalkZone == true) && (transform.position.x > maxWalkPoint.x) ) //If npc cannot go that direction
					{
						isWalking = false;
						anim.SetBool("GolWalk", false);
						waitCounter = waitTime;
					}
					else //If they can go
					{
						anim.SetFloat ("inputX", 1);
						anim.SetFloat ("inputY", 0);
					}
					
					
					break;
				}
				
				case 2:
				{
					rb.velocity = new Vector2(0, -moveSpeed); //y value decreases - Down
					
					if( (hasWalkZone == true) && (transform.position.y < minWalkPoint.y) ) //If npc cannot go that direction
					{
						isWalking = false;
						anim.SetBool("GolWalk", false);
						waitCounter = waitTime;
					}
					else //If they can go
					{
						anim.SetFloat ("inputX", 0);
						anim.SetFloat ("inputY", -1);
					}
					
					
					break;
				}
				
				case 3:
				{
					rb.velocity = new Vector2(-moveSpeed, 0); //x value decreases - Left
					
					if( (hasWalkZone == true) && (transform.position.x < minWalkPoint.x) ) //If npc cannot go that direction
					{
						isWalking = false;
						anim.SetBool("GolWalk", false);
						waitCounter = waitTime;
					}
					else //If they can go
					{
						anim.SetFloat ("inputX", -1);
						anim.SetFloat ("inputY", 0);
					}
					
					
					break;
				}
				
			}//end switch
			
			if(walkCounter < 0)
			{
				isWalking = false;
				anim.SetBool("GolWalk", false);
				waitCounter = waitTime;
			}
			
		}
		else
		{
			
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
