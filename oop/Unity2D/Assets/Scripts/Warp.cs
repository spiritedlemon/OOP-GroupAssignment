using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {
	
	
	public Transform WarpTarget;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log("An object Collided");
		
		other.gameObject.transform.position = WarpTarget.position; //Changes player's destination to warptarget
		Camera.main.transform.position = WarpTarget.position;	//Teleports camera to character instead of dragging it between maps
	}
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
