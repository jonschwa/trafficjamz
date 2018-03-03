using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingSound : MonoBehaviour {

	AudioSource audio;
	MovingBehavior movingObj;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		movingObj = GetComponent<MovingBehavior>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!movingObj.stopped) {
			if (!audio.isPlaying)
				audio.Play ();
		} else {
			if (audio.isPlaying)
				audio.Stop ();
		}
	}
}
