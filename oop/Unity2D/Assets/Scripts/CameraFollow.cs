using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
	public Transform target; //Stores Position, scale and rotation data
	public float c_speed = 0.1f;	//Affects move speed of the camera
	Camera mycam;
	

	// Use this for initialization
	void Start () {
		
		mycam = GetComponent<Camera> ();
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
		mycam.orthographicSize = (Screen.height / 100f) / 1.75f;	//Should scale the camera size to fit any screen size
		
		if(target)
		{
			
			transform.position = Vector3.Lerp(transform.position, target.position, c_speed) + new Vector3(0, 0, -10);
			
		}
	
	}
}
