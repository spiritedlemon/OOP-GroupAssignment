 using System.Collections;
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
		if(other.gameObject.name == "SlimeAIEnemy1")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
		if(other.gameObject.name == "SlimeAIEnemy2")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
		if(other.gameObject.name == "SlimeAIEnemy3")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
		if(other.gameObject.name == "SlimeAIEnemy4")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
		if(other.gameObject.name == "RedDemonAI")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
		if(other.gameObject.name == "BatEnemy1")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
		if(other.gameObject.name == "BatEnemy2")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
		if(other.gameObject.name == "BatEnemy3")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
		if(other.gameObject.name == "BatEnemy4")
		{
			other.gameObject.GetComponent<EnemyHP>().HurtEnemy(damage);	//Pass damage to the HurtEnemy Fnc
		}
	}

}
