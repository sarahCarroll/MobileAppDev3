using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

    [SerializeField]
    private float elaspedTime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        elaspedTime += Time.deltaTime;
        Debug.Log(elaspedTime);
	}
}
