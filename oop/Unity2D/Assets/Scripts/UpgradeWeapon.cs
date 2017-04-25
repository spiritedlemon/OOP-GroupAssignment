using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeapon : MonoBehaviour {


	
	
	public Collider2D Cave;
	
	private bool upgradeDone;
	
	private Vector2 minPoint;
	private Vector2 maxPoint;
	
	//public GameObject player;
	
	// Use this for initialization
	void Start () 
	{
		
		//GameObject.FindWithTag("Weapon2").SetActive(false);
		//	Debug.Log("Weapon2Disabled");
		upgradeDone = false;
		
		if(Cave != null)	//Whole event only happens if area is present
		{
			minPoint = Cave.bounds.min;
			maxPoint = Cave.bounds.max;
		}
	}
	
	
	void OnTriggerEnter2D(Collider2D Other)
	{
		
			//Can't of already got upgrade
			if( (upgradeDone == false) && (transform.position.y < maxPoint.y) && (transform.position.y > minPoint.y) ) 
			{
				if( (transform.position.x < maxPoint.x) && (transform.position.x > minPoint.x) )
				{
					//GameObject.Find("Sword1").SetActive(false);
					//Debug.Log("Weapon1Disabled");
					//GameObject.Find("Sword2").SetActive(true);
					//GameObject.FindWithTag("Weapon2").SetActive(true); //Older attempt
					//Debug.Log("Weapon2Enabled");
					
					print("Weapon upgrade diabled due to bugs - Can activate sword2 manually in hierarchy");
					
					//upgradeDone = true;
				}
			}
		
		
		
	}
	
	
	
	
	
}
