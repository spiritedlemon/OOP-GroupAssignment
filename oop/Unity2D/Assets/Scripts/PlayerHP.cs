//Script to track player Current and max HP

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {
	
	public int playerMaxHP = 100;
	public int playerCurrentHP;
	

	// Use this for initialization
	void Start () 
	{
		playerCurrentHP = playerMaxHP; //At start of game fill HP
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(playerCurrentHP <= 0)
		{
			gameObject.SetActive(false);
		}
		
	}
	
	public void HurtPlayer(int damage)
	{
		playerCurrentHP = playerCurrentHP - damage;  //Deal damage to player
	}
	
	public void SetMaxHP()
	{
		playerCurrentHP = playerMaxHP; //If you need to fill the player's hp (potions or something)
	}
	
}
