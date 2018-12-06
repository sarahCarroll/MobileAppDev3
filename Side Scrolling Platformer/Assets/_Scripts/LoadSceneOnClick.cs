using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)
    {
        Time.timeScale = 1.0f; // begin time in the game when game starts
        SceneManager.LoadScene(sceneIndex); //call this function in the onclick and choose given index of scene
        Debug.Log("scene changed");//testing debug
    }
}
