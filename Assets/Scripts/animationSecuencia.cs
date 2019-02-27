using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationSecuencia: MonoBehaviour {
	public GameObject Hombro;
	public GameObject AnteBrazo;
	public GameObject Codo;
	public GameObject Brazo;
	public GameObject muñeca1;
	public GameObject muñeca2;
	public GameObject muñeca3;
	public GameObject Pinza;


	public Material verdeazulado;
	public Material gris;


	void Update () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		float x = Input.GetAxisRaw ("Mouse X");
		float y = Input.GetAxisRaw ("Mouse Y");

		float x1 = Input.GetAxisRaw ("Flecha X");
		float y1 = Input.GetAxisRaw ("Flecha Y");


	

		if (h != 0) {
			Hombro.GetComponent<Renderer>().material.color = Color.red;		
		} else {
			Hombro.GetComponent<Renderer> ().material.color = verdeazulado.color;
		}

		if (v != 0) {
			AnteBrazo.GetComponent<Renderer>().material.color = Color.red;		
		} else {
			AnteBrazo.GetComponent<Renderer> ().material.color = gris.color;
		}


		if (x != 0) {
			Codo.GetComponent<Renderer>().material.color = Color.green;		
		} else {
			Codo.GetComponent<Renderer>().material.color = verdeazulado.color;
		}
			
		if (y != 0) {
			Brazo.GetComponent<Renderer>().material.color = Color.green;		
		} else {
			Brazo.GetComponent<Renderer> ().material.color = gris.color;
		}

		if (x1 != 0) {
			muñeca1.GetComponent<Renderer>().material.color = Color.blue;		
		} else {
			muñeca1.GetComponent<Renderer> ().material.color = verdeazulado.color;
		}
		if (y1 != 0) {
			muñeca2.GetComponent<Renderer>().material.color = Color.blue;		
		} else {
			muñeca2.GetComponent<Renderer> ().material.color = gris.color;
		}


		if (Input.GetButton ("button4")) {
			Pinza.GetComponent<Renderer> ().material.color = Color.yellow;
		} else {
			Pinza.GetComponent<Renderer> ().material.color = verdeazulado.color;
		}


		if (Input.GetButton ("button5")) {
			Pinza.GetComponent<Renderer> ().material.color = Color.yellow;
		} else {
			Pinza.GetComponent<Renderer> ().material.color = verdeazulado.color;
		}

	
	}
}