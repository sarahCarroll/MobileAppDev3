using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public bool musicIsPlaying = true;
    public AudioSource backgroundMusic;

    private void Awake()
    {
        if (musicIsPlaying)
        {
            DontDestroyOnLoad(transform.gameObject);
        }

        if (FindObjectsOfType(typeof(Audio)).Length > 1)
        {
            //Destroy(transform.gameObject);
            return; // don't allow code to continue executing since we're destroy this "extra" copy.
        }
    }
    

    public void changeBackgroundMusic(AudioClip music)
    {
        
        Debug.Log("change mussic");
        //Destroy(gameObject);
        //pause the current music playing
        backgroundMusic.Pause();
        //read in the clip passed in 
        backgroundMusic.clip = music;
        //Play new song
        backgroundMusic.Play();
        
    }

  
}
