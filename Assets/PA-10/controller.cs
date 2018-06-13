using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    public Transform Hombro;
    public Transform AnteBrazo;
    public Transform Codo;
    public Transform Brazo;
    public Transform muñeca1;
    public Transform muñeca2;
    public Transform muñeca3;
    public float deltaMovimiento=500;
	// Use this for initialization
	void Start () {
      
	}
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            Hombro.Rotate(new Vector3(0f, deltaMovimiento, 0f) * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            Hombro.Rotate(new Vector3(0f, -deltaMovimiento, 0f) * Time.deltaTime);

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

        mando();
    }

    // Update is called once per frame
    
    void mando() {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Hombro.Rotate(new Vector3(v*100f, 0f, 0f) * Time.deltaTime);
        Hombro.Rotate(new Vector3( 0f,h * 100f, 0f) * Time.deltaTime);
    }
    
}
