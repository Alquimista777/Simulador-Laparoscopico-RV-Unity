using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		anim.SetFloat ("GetAxis", v);
		anim.SetFloat ("GetAxisH",h);




	}
}
