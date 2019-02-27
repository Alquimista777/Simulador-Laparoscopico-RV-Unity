using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEstomago : MonoBehaviour {

	public GameObject newposition;
	public GameObject player;





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		Renderer render = GetComponent<Renderer>();
		render.material.color = Color.blue;
		player.transform.position = newposition.transform.position;
	//	GameObject.Find ("HOMBRO").SendMessage("reducirdeltamovimiento");


		// Handheld.Vibrate();
	}


}
