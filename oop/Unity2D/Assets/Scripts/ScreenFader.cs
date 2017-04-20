using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFader : MonoBehaviour {
	
	Animator anim;
	bool isFading = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		
		
	}
	
	public IEnumerator FadeToClear()
	{
		isFading = true;
		anim.SetTrigger("FadeIn");
		
		while (isFading)		//Infinitely run until criteria is met
			yield return null;
		
	}
	
	public IEnumerator FadeToBlack()
	{
		isFading = true;
		anim.SetTrigger("FadeOut");
		
		while (isFading)		//Infinitely run until criteria is met
			yield return null;
		
	}
	
	
	void AnimationComplete() // When animation complete - set isFading back to false
	{
		isFading = false;
		
	}
	
	
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
