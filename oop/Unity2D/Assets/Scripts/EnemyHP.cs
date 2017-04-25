using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {

	//variables 
	public int EnemyMaxHP = 100; 
	public int EnemyCurrentHP;


	// Use this for initialization
	void Start () 
	{
		EnemyCurrentHP = EnemyMaxHP; //At start of game fill HP

	}

	// Update is called once per frame
	void Update () 
	{

		if(EnemyCurrentHP <= 0)
		{
			gameObject.SetActive(false); //destroys the enemy and stops displaying them 
		}

	}

	public void HurtEnemy(int damage)
	{
		EnemyCurrentHP = EnemyCurrentHP - damage;  //Deal damage to player
	}

	public void SetMaxHP()
	{
		EnemyCurrentHP = EnemyMaxHP; //If you need to fill the player's hp (potions or something)
	}

}
