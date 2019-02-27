using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contollerVrBox : MonoBehaviour {
	public Transform Hombro;
	public Transform AnteBrazo;
	public Transform Codo;
	public Transform Brazo;
	public Transform muñeca1;
	public Transform muñeca2;
	public Transform muñeca3;
	public Transform Pinza;
	public float deltaMovimiento;
	public float pinzaSpeed;


	void Update () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Hombro.Rotate(new Vector3(0f,h*deltaMovimiento,0f) * Time.deltaTime);
		AnteBrazo.Rotate(new Vector3(v * deltaMovimiento, 0f, 0f) * Time.deltaTime);
		/*
		butotn3=A
		button0=B
		button2=C
		button1=D

		*/
		if(Input.GetButton ("button3")){
			Brazo.Rotate (new Vector3(deltaMovimiento,0f,0f)*Time.deltaTime);

		}
		if(Input.GetButton ("button0") || Input.GetKeyUp(KeyCode.P) ){
			Brazo.Rotate (new Vector3(-deltaMovimiento,0f,0f)*Time.deltaTime);

		}

		if(Input.GetButton ("button2")){
			Codo.Rotate (new Vector3(0f,-deltaMovimiento,0f)*Time.deltaTime);
		}
		if(Input.GetButton ("button1")){
			Codo.Rotate (new Vector3(0f,deltaMovimiento,0f)*Time.deltaTime);
		}


	//	if (Input.GetButton("Fire1"))
//		    Pinza.Translate(Vector3.up * 1 * Time.deltaTime);

//		if (Input.GetButton("Fire2"))
//			Pinza.Translate(Vector3.down * 1 * Time.deltaTime);


	}
}
