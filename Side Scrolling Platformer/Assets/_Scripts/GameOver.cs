using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text scoreText; // text last score achieved
    public Text highText; // text high score

    // Use this for initialization
    void Start () {
        highText.text = PlayerPrefs.GetInt("highScore").ToString(); // print out the players highscore
        scoreText.text = PlayerPrefs.GetInt("score").ToString(); //print players last score achived
    }

}
