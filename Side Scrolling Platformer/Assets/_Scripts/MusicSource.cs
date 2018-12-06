using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSource : MonoBehaviour {

    //variable gameobject audiomanager
    private GameObject am;

    //serializefield so it can be changed in unity window
    [SerializeField]
    private AudioClip music;

    // Use this for initialization
    void Start () {
        //link am with the gameobject tagged audiomanager
        am = GameObject.FindGameObjectWithTag("audioManager");
        //testing degug
        Debug.Log(am.name);
    }
	
	public void ChangeMusic()
    {
        //call changeBackgroundMusic funtion in the audio class
        am.GetComponent<Audio>().changeBackgroundMusic(music);
        //Debug.Log("music changed to summer");
    }
}
