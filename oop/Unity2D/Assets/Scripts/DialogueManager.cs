using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
	
	public GameObject dBox;
	public Text dText;
	
	public bool dialogueActive;
	
	

	// Use this for initialization
	void Start () {
		dBox.SetActive(false);
		dialogueActive = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if( dialogueActive && Input.GetKeyDown(KeyCode.E) )	//Press e to continue
		{
			
			dBox.SetActive(false);
			dialogueActive = false;
			
		}
		
		
	}
	
	
	public void ShowBox(string dialogue) //Used to display string in box
	{
		
		dBox.SetActive(true);
		dialogueActive = true;
		dText.text = dialogue;
		
	}
	
	

	
	
}

/* - Golem Conversation
It has been some time since a human has stopped by... 
The last one left something here
Maybe he was hiding it, who knows...
I have long since given up guessing
*/





