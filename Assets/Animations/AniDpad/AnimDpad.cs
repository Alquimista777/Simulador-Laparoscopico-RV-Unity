using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDpad : MonoBehaviour {

	// Use this for initialization
	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();

	}

	// Update is called once per frame
	void Update () {

		float h = Input.GetAxisRaw ("Flecha X");
		float v = Input.GetAxisRaw ("Flecha Y");

		anim.SetFloat ("GetAxis", v);
		anim.SetFloat ("GetAxisH",h);




	}
}
