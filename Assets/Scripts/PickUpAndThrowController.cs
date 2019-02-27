using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpAndThrowController : MonoBehaviour {
    public  Transform onhand;
    public GameObject Obj;
    public GameObject Robot;

    public float d ;
    public float Distance;

    void UpDate() {
       
    }
     
    void FixedUpdate() {

        PickUp();
        PickThrow();
    }
	void PickUp(){
		Distance = Vector3.Distance(Obj.transform.position, Robot.transform.position);
       

		if (Input.GetButton("button6"))
        {
            if (Distance < d)
            {
                GetComponent<Rigidbody>().useGravity = false;
                this.transform.position = onhand.position;
                this.transform.parent = GameObject.Find("Robot1").transform;
                this.transform.parent = GameObject.Find("HOMBRO").transform;
                this.transform.parent = GameObject.Find("ANTEBRAZO").transform;
                this.transform.parent = GameObject.Find("CODO").transform;
                this.transform.parent = GameObject.Find("BRAZO").transform;
                this.transform.parent = GameObject.Find("MUNECA1").transform;
                this.transform.parent = GameObject.Find("MUNECA2").transform;
                this.transform.parent = GameObject.Find("MUNECA3").transform;
                this.transform.parent = GameObject.Find("PINZA_T").transform;
            }
        }

		if (Input.GetButton("Fire1"))
		{
			if (Distance < d)
			{
				GetComponent<Rigidbody>().useGravity = false;
				this.transform.position = onhand.position;
				this.transform.parent = GameObject.Find("Robot1").transform;
				this.transform.parent = GameObject.Find("HOMBRO").transform;
				this.transform.parent = GameObject.Find("ANTEBRAZO").transform;
				this.transform.parent = GameObject.Find("CODO").transform;
				this.transform.parent = GameObject.Find("BRAZO").transform;
				this.transform.parent = GameObject.Find("MUNECA1").transform;
				this.transform.parent = GameObject.Find("MUNECA2").transform;
				this.transform.parent = GameObject.Find("MUNECA3").transform;
				this.transform.parent = GameObject.Find("PINZA_T").transform;
			}
		}
	
	}
    /**void OnMouseDown()
    {

        Distance = Vector3.Distance(Obj.transform.position, Robot.transform.position);
        if (Distance < d)
        {

            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = onhand.position;
            this.transform.parent = GameObject.Find("Robot1").transform;
            this.transform.parent = GameObject.Find("HOMBRO").transform;
            this.transform.parent = GameObject.Find("ANTEBRAZO").transform;
            this.transform.parent = GameObject.Find("CODO").transform;
            this.transform.parent = GameObject.Find("BRAZO").transform;
            this.transform.parent = GameObject.Find("MUNECA1").transform;
            this.transform.parent = GameObject.Find("MUNECA2").transform;
            this.transform.parent = GameObject.Find("MUNECA3").transform;
            this.transform.parent = GameObject.Find("PINZA_T").transform;
        }
        
    }
    **/
    void PickThrow()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity=true;

    }

  
}

