using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContrllerCshar : MonoBehaviour {

   
    public Transform hombro;
    public Transform antebrazo;
    public Transform brazo;
    public Transform muñeca2;


    public float velocidad= 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButton("Fire1")){
         antebrazo.Rotate(new Vector3(velocidad, 0f, 0f) * Time.deltaTime);

        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        antebrazo.Rotate(new Vector3(-v*velocidad,0f,0f)*Time.deltaTime);
      
        hombro.Rotate(new Vector3(0, h*velocidad, 0f) * Time.deltaTime);
    }
	}

