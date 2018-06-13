using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ante : MonoBehaviour
{
    public Rigidbody antebrazo;
    Vector3 eulerRotation;
    public float deltaMovimiento;
    // Use this for initialization
    void Start()
    {
        antebrazo = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            float h = Input.GetAxis("Vertical");
            eulerRotation = new Vector3(h * deltaMovimiento, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerRotation * Time.deltaTime);
            antebrazo.MoveRotation(antebrazo.rotation * deltaRotation);
        }
    }
}
