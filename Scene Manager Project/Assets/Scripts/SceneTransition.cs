using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition : MonoBehaviour 
{
    public Animator animator; // Animator to control the transition 

    // Use this for initialization
    void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        if(Input.anyKey)
        {
            animator.SetTrigger("FadeOut");
        }

	}
}
