using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.DisableKeyword("_EMISSION");

        int sibIdx = transform.GetSiblingIndex();
        int numSibs = transform.parent.childCount;
        sibIdx = (sibIdx + Random.Range(1, numSibs)) % numSibs;
        int sibIdx2 = (sibIdx + Random.Range(1, numSibs)) % numSibs;
        GameObject randomSib = transform.parent.GetChild(sibIdx).gameObject;
        GameObject randomSib2 = transform.parent.GetChild(sibIdx2).gameObject;

        Vector3 randomSibposition = randomSib.transform.position;
        Vector3 randomSib2position = randomSib2.transform.position;

        Vector3 tempPosition = randomSibposition;
        randomSibposition = randomSib2position;
        randomSib2position = tempPosition;
        
   
        Debug.Log(randomSib);
        Debug.Log(randomSib2);

       // Handheld.Vibrate();
    }
}
