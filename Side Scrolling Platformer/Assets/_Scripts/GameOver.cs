using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text scoreText;
    public Text highText;

    // Use this for initialization
    void Start () {
        highText.text = PlayerPrefs.GetInt("highScore").ToString();
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
