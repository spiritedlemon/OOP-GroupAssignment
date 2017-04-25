using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeapon : MonoBehaviour {


	
	
	public Collider2D Cave;
	
	private bool upgradeDone = false;
	
	private Vector2 minPoint;
	private Vector2 maxPoint;
	
	void OnTriggerEnter2D(Collider2D Other)
	{
		if(Cave != null)	//Whole event only happens if area is preset
		{
			minPoint = Cave.bounds.min;
			maxPoint = Cave.bounds.max;
			
			//Can't of already got upgrade
			if( (upgradeDone == false) && (transform.position.y <= maxPoint.y) && (transform.position.y >= minPoint.y) ) 
			{
				if( (transform.position.x <= maxPoint.x) && (transform.position.x >= minPoint.x) )
				{
					GameObject.FindWithTag("Weapon").SetActive(false);
					GameObject.FindWithTag("Weapon2").SetActive(true);
					upgradeDone = true;
				}
			}
			
		}
		
		
		
	}
	
	
	
	
	
}
