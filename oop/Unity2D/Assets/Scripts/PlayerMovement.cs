//Script to control player movement


using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	
	Rigidbody2D rbody;
	Animator anim;
	
	private bool attacking;
	public float attTime; //How long player attacks for
	private float attTimeCounter;

	// Use this for initialization
	void Start () 
	{
		
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(!attacking)
		{
		Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical") );
			
		if(movement_vector != Vector2.zero)
		{
			anim.SetBool ("iswalking", true);
			anim.SetFloat ("Input_x", movement_vector.x);
			anim.SetFloat ("Input_y", movement_vector.y);
		}
		else
		{
			anim.SetBool ("iswalking", false);
		}
		
		rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime);
		
		
		
		//Attacking Happens here
		if(Input.GetKeyDown(KeyCode.Space))
		{
			attTimeCounter = attTime;
			attacking = true; 
			rbody.velocity = Vector2.zero;
			anim.SetBool("Attack", true);
			
		}
		
		}//End of IfNotAttacking
		
		if(attTimeCounter > 0)
		{
			
			attTimeCounter -= Time.deltaTime;
			
		}
		
		if(attTimeCounter >= 0)
		{
			
			attacking = false;
			anim.SetBool("Attack", false);
			
		}
		
		
	}//end of update
}
