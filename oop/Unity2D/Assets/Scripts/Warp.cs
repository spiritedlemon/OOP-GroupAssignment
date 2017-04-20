using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {
	
	
	public Transform WarpTarget;
	
	IEnumerator OnTriggerEnter2D(Collider2D other)	//Changed to Enumerator to use yield statements
	{
		ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader> ();
		
		//??.GetComponent<PlayerMovement>().enable = false; //Failed Attempt to freeze player for fade out 
		
		yield return StartCoroutine(sf.FadeToBlack () ); //Fades screen before player is moved
		
		
		//Debug.Log("An object Collided"); //For De-bugging
		
		other.gameObject.transform.position = WarpTarget.position; //Changes player's destination to warptarget
		Camera.main.transform.position = WarpTarget.position;	//Teleports camera to character instead of dragging it between maps
		
		
		yield return StartCoroutine(sf.FadeToClear () ); //Clears screen after player has been moved
		
		//??.GetComponent<PlayerMovement>().enable = true; //Failed Attempt to freeze player for fade out 
	}
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
