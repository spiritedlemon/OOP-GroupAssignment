﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour {

	public int damage;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.name == "Enemies")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
	}

}
