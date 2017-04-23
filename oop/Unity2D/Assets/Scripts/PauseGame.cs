using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

	//variables 
	public Transform PauseMenu;

	// Use this for initialization
	void Start () {
		//not needed in this script
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (PauseMenu.gameObject.activeInHierarchy == false) 
			{
				PauseMenu.gameObject.SetActive(true);
			} else 
			{
				PauseMenu.gameObject.SetActive (false);
			}
		}
	}
}
