using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlR : MonoBehaviour {
	public Animator joystickR;
	// Use this for initialization
	void Start () {
		joystickR = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float y = Input.GetAxisRaw ("Mouse Y");
		float x = Input.GetAxisRaw ("Mouse X");

		joystickR.SetFloat ("GetAxisVertical", y);
		joystickR.SetFloat ("GetAxisHorizontal", x);
	}
}
