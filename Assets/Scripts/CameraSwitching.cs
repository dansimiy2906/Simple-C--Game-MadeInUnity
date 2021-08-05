using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    public Camera Aerial;
    public Camera camera;
    public float secondsCount;
    void Start()
    {
    	Aerial.enabled = true;
    	camera.enabled = false;
  
    }

    // Update is called once per frame
    void Update()
    {
    	secondsCount += Time.deltaTime;
    	if(secondsCount > 1f){
    		Aerial.enabled = false;
    		camera.enabled = true;
    	}
        
    }
}
