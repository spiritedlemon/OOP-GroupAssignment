using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

	//variables 
	public Transform canvas;
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
		if (canvas.gameObject.activeInHierarchy == false) 
		{
			canvas.gameObject.SetActive(true);
			Time.timeScale = 0;
			Player.GetComponent<CameraFollow> ().enabled = false;
		} else 
		{
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			Player.GetComponent<CameraFollow> ().enabled = true;
		}
	}
}
