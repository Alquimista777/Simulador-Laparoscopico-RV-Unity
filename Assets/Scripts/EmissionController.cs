using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionController : MonoBehaviour {
    public Material cubeBlue;
    public Material cubeYellow;
    public Material cubeRed;
    public Material cubeGreen;
    public Material cubePurple;
    public Material cubeOrange;
    public Material cubePink;
    public Material cubeGray;
    // Use this for initialization
    void Awake () {
        cubeBlue.DisableKeyword("_EMISSION");
        cubeYellow.DisableKeyword("_EMISSION");
        cubeRed.DisableKeyword("_EMISSION");
        cubeGreen.DisableKeyword("_EMISSION");
        cubePurple.DisableKeyword("_EMISSION");
        cubeOrange.DisableKeyword("_EMISSION");
        cubePink.DisableKeyword("_EMISSION");
        cubeGray.DisableKeyword("_EMISSION");
    }
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= 3.0f)
        {
            cubeBlue.EnableKeyword("_EMISSION");
            cubeYellow.EnableKeyword("_EMISSION");
            cubeRed.EnableKeyword("_EMISSION");
            cubeGreen.EnableKeyword("_EMISSION");
            cubePurple.EnableKeyword("_EMISSION");
            cubeOrange.EnableKeyword("_EMISSION");
            cubePink.EnableKeyword("_EMISSION");
            cubeGray.EnableKeyword("_EMISSION");
        }

	}
    
}
