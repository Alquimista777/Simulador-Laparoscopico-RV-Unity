using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backcameraposition : MonoBehaviour {
	public GameObject backposition;
	public GameObject player;

	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{

		if(other.gameObject.name == "CubeAzul"){
			player.transform.position = backposition.transform.position;

		}
	}
}
