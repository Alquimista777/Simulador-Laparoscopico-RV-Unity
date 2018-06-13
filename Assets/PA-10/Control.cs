using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Rigidbody Hombro;
    public Rigidbody AnteBrazo;
    public Rigidbody Codo;
    public Rigidbody Brazo;
    public Rigidbody muñeca2;
    Vector3 eulerRotation;


    public float deltaMovimiento;
    // Use this for initialization
    void Start()
    {
        Hombro = this.gameObject.GetComponent<Rigidbody>();
        AnteBrazo = this.gameObject.GetComponent<Rigidbody>();
        Codo = this.gameObject.GetComponent<Rigidbody>();
        Brazo = this.gameObject.GetComponent<Rigidbody>();
        muñeca2 = this.gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            eulerRotation = new Vector3(0, deltaMovimiento, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerRotation * Time.deltaTime);
            Hombro.MoveRotation(Hombro.rotation * deltaRotation);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            eulerRotation = new Vector3(deltaMovimiento, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerRotation * Time.deltaTime);
            AnteBrazo.MoveRotation(AnteBrazo.rotation * deltaRotation);
        }
        if (Input.GetAxis("Codo") != 0)
        {
            eulerRotation = new Vector3(0, deltaMovimiento, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerRotation * Time.deltaTime);
            Codo.MoveRotation(Codo.rotation * deltaRotation);
        }
        if (Input.GetAxis("Brazo") != 0)
        {
            eulerRotation = new Vector3(deltaMovimiento, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerRotation * Time.deltaTime);
            Brazo.MoveRotation(Brazo.rotation * deltaRotation);
        }

        if (Input.GetAxis("Muñeca2") != 0)
        {
            eulerRotation = new Vector3(deltaMovimiento, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerRotation * Time.deltaTime);
            muñeca2.MoveRotation(muñeca2.rotation * deltaRotation);
        }
    }
}

      