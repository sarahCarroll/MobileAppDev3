using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour {

    void Start()
    {
        StartCoroutine(LoadMainMenu());
    }

    IEnumerator LoadMainMenu()
    {
        Debug.Log("enter splashscreenController");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);// Load main menu after 2 seconds
        Debug.Log("loaded scene 0");

    }
}
