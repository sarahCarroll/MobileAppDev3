using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public bool musicIsPlaying = true;

    public void mute()
    {
        if (musicIsPlaying)
        {
            AudioListener.pause = true;
            musicIsPlaying = false;
        }
        else
        {
            AudioListener.pause = false;
            musicIsPlaying = true;
        }
           
        
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
