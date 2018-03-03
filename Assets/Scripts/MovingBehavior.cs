using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBehavior : MovingObject {

	public bool stopped;

	// Use this for initialization
	void Awake () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//@todo - this will be determined by the gamecontroller changing this gameobject's parent
		if (Input.GetKey("down")) {
			stopped = true;
		} else {
			stopped = false;
		}
		Move(0, 1, stopped);
	}
}
