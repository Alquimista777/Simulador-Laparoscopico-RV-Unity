using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerTeclado : MonoBehaviour {
    public Transform Hombro;
    public Transform AnteBrazo;
    public Transform Codo;
    public Transform Brazo;
    public Transform muñeca1;
    public Transform muñeca2;
    public Transform muñeca3;
    public float deltaMovimiento = 0f;
	// Use this for initialization
	void Start () {
      
	}
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            Hombro.Rotate(new Vector3(0f, -deltaMovimiento, 0f) * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            Hombro.Rotate(new Vector3(0f, deltaMovimiento, 0f) * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            AnteBrazo.Rotate(new Vector3(deltaMovimiento, 0f, 0f) * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            AnteBrazo.Rotate(new Vector3(-deltaMovimiento, 0f, 0f) * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            Codo.Rotate(new Vector3(0f, deltaMovimiento, 0f) * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            Codo.Rotate(new Vector3(0f, -deltaMovimiento, 0f) * Time.deltaTime);

        if (Input.GetKey(KeyCode.X))
            Brazo.Rotate(new Vector3(deltaMovimiento, 0f, 0f) * Time.deltaTime);
        if (Input.GetKey(KeyCode.C))
            Brazo.Rotate(new Vector3(-deltaMovimiento, 0f, 0f) * Time.deltaTime);

        if (Input.GetKey(KeyCode.P))
            muñeca2.Rotate(new Vector3(deltaMovimiento, 0f, 0f) * Time.deltaTime);
        if (Input.GetKey(KeyCode.O))
            muñeca2.Rotate(new Vector3(-deltaMovimiento, 0f, 0f) * Time.deltaTime);

        
    }

    // Update is called once per frame
	/*public void reducirdeltamovimiento(){
		deltaMovimiento = 5f;
	}*/
    
   
}
