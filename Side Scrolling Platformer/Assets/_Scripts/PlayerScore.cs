using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

    private Text scoreText;

    private int playerScore = 0;

    [SerializeField]
    private float elaspedTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        elaspedTime += Time.deltaTime;
        Debug.Log(elaspedTime);
        scoreText.text = playerScore.ToString("000000");
	}
}
