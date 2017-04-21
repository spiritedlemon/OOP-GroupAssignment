//Script to control damage dealt to player by ANY enemy

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour {
	
	public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.name == "Player")
		{
			other.gameObject.GetComponent<PlayerHP>().HurtPlayer(damage);	//Pass damage to the HurtPlayer Fnc
		}
	}
	
}
