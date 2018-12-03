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
    }

    public void changeBackgroundMusic(AudioClip music)
    {
        Debug.Log("change mussic");
        backgroundMusic.Stop();
        backgroundMusic.clip = music;
        backgroundMusic.Play();

    }
}
