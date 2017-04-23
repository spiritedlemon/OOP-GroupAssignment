using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

	//variables 
	public Transform PauseMenu;
	public Transform Player;

	// Use this for initialization
	void Start () {
		//not needed in this script
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Pause(); //calling the pause method 
		}
	}
	public void Pause()
	{
		if (PauseMenu.gameObject.activeInHierarchy == false) 
		{
			PauseMenu.gameObject.SetActive(true);
			Time.timeScale = 0;
			Player.GetComponent<CameraFollow> ().enabled = false;
		} else 
		{
			PauseMenu.gameObject.SetActive (false);
			Time.timeScale = 1;
			Player.GetComponent<CameraFollow> ().enabled = true;
		}
	}
}
