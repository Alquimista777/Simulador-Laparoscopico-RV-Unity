using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play2Controller : MonoBehaviour {
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

	void Start()
	{

	}

	void Update () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		float x = Input.GetAxisRaw ("Mouse X");
		float y = Input.GetAxisRaw ("Mouse Y");

		float x1 = Input.GetAxisRaw ("Flecha X");
		float y1 = Input.GetAxisRaw ("Flecha Y");

		Hombro.Rotate(new Vector3(0f,h*deltaMovimiento,0f) * Time.deltaTime);
		AnteBrazo.Rotate(new Vector3(v * deltaMovimiento, 0f, 0f) * Time.deltaTime);

		Codo.Rotate(new Vector3( 0f, x * deltaMovimiento, 0f) * Time.deltaTime);
		Brazo.Rotate(new Vector3(y * deltaMovimiento, 0f, 0f) * Time.deltaTime);

		muñeca1.Rotate(new Vector3(0f, x1 * deltaMovimiento, 0f) * Time.deltaTime);
		muñeca2.Rotate(new Vector3(y1 * deltaMovimiento, 0f, 0f) * Time.deltaTime);


	
		if(Input.GetButton ("button4")){
			Pinza.Translate(Vector3.up * pinzaSpeed * Time.deltaTime);
		}

		if(Input.GetButton ("button5")){
			Pinza.Translate(Vector3.down * pinzaSpeed * Time.deltaTime);
		}





		//if (Input.GetButton("Fire1"))
		//    Pinza.Translate(Vector3.up * 1 * Time.deltaTime);

		//if (Input.GetButton("Fire2"))
		//    Pinza.Translate(Vector3.down * 1 * Time.deltaTime);


	}
}
