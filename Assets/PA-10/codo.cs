using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codo : MonoBehaviour {

    // Use this for initialization
    public Rigidbody codos;
    Vector3 eulerRotation;
    public float deltaMovimiento;
    void Start () {
        codos = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Codo") != 0)
        {
            float h = Input.GetAxis("Codo");
            eulerRotation = new Vector3(0, h * deltaMovimiento, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerRotation * Time.deltaTime);
            codos.MoveRotation(codos.rotation * deltaRotation);
        }
    }
}
