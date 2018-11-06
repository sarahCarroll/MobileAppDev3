using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour {

    public bool musicIsPlaying = true;

    public Slider volumeSlider;

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

    public void volume()
    {
        AudioListener.volume = volumeSlider.value;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
