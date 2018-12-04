using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSource : MonoBehaviour {

    private GameObject am;

    [SerializeField]
    private AudioClip music;

    // Use this for initialization
    void Start () {
        am = GameObject.FindGameObjectWithTag("audioManager");
        Debug.Log(am.name);
    }
	
	public void ChangeMusic()
    {
        am.GetComponent<Audio>().changeBackgroundMusic(music);
        Debug.Log("music changed to summer");
    }
}
