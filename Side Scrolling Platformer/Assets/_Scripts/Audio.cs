using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public bool musicIsPlaying = true;
    public AudioSource backgroundMusic;

    int counter = 0;

    static Audio instance = null;

    void Start()
    {
        
    }



    private void Awake()
    {

        

        /*if (instance != false)
        {
            Destroy(gameObject);
            Debug.Log("destroy music");

        }
            

        else if(instance == false)
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            Debug.Log("play music");
        }*/
        if (musicIsPlaying)
        {
            DontDestroyOnLoad(transform.gameObject);
        }

        if (FindObjectsOfType(typeof(Audio)).Length > 1)
        {
            //Destroy(transform.gameObject);
            return; // don't allow code to continue executing since we're destroy this "extra" copy.
        }

       

        var _audio = this.GetComponent<AudioSource>();
        if (_audio.clip != null && _audio.time == 0)
        { // check if audio clip assigned and only do this if it hasn't started playing yet (position == 0)
            _audio.Play();
        }
    }
    

    public void changeBackgroundMusic(AudioClip music)
    {
        
            Debug.Log("change mussic");
            //Destroy(gameObject);
            backgroundMusic.Pause();
            backgroundMusic.clip = music;
            backgroundMusic.Play();
        
    }

  
}
