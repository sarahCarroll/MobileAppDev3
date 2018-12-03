using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour {

    public AudioClip newTrack;

    private Audio theAM;

	// Use this for initialization
	void Start () {
        //make a direct reference to audio script to change the song playing
        theAM = FindObjectOfType<Audio>();
	}
	
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(newTrack!= null)
            {
                theAM.changeBackgroundMusic(newTrack);
            }
        }
    }
}
