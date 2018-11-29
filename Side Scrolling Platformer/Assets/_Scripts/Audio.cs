using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public bool musicIsPlaying = true;

    private void Awake()
    {
        if (musicIsPlaying)
        {
            DontDestroyOnLoad(transform.gameObject);
        }
       
       
    }
}
