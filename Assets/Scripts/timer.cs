using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour {
	
    public Text tiempoText;
	private float startTime;
	private bool finalizar = false;
  
	void Start(){
		startTime = Time.time;

	}

    
    // Update is called once per frame
    public void Update() {


		if (finalizar)
			return;
			float t = Time.time - startTime;
			string minutes = ((int) t / 60).ToString ();
			string seconds = (t % 60).ToString ("f2");
			tiempoText.text = minutes + ":" + seconds;

        }

	public void Finnish (){
		finalizar = true;
		tiempoText.color = Color.yellow;
	}

	public void Iniciar (){

		tiempoText.color = Color.yellow;
	}




}
  

