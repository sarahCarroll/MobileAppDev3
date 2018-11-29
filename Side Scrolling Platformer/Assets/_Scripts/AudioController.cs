using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour {

    public bool musicIsPlaying = true; // boolean to say if music is playing

    public Slider volumeSlider; // defines volume slider

    public void mute()
    {
        if (musicIsPlaying)// is the number player = true
        {
            AudioListener.pause = true; //pause music
            musicIsPlaying = false; //set music playing to false
        }
        else
        {
            AudioListener.pause = false; //resume music
            musicIsPlaying = true; //set music playing to true
        }
           
        
    }

    public void volume()
    {
        AudioListener.volume = volumeSlider.value; //ajust the volume of the music by the volume slider
    }
}
