﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //for the user interface components such as a slider


public class EnemyHealthLevelControl : MonoBehaviour {

	//variables
	public Slider healthbar;
	public Texture HealthText;
	public EnemyHP EnemyHealth;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		healthbar.maxValue = EnemyHealth.EnemyMaxHP;
		healthbar.value = EnemyHealth.EnemyCurrentHP;
		//healthbar.maxValue = playerHealth.EnemyMaxHP;
	}
}
