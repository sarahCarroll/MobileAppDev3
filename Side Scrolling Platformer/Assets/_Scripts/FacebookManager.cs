using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Facebook.Unity;

public class FacebookManager : MonoBehaviour {

    public Text UserId;

    private void Awake()
    {
        if (!FB.IsInitialized)
        {
            FB.Init();
        }
        else
        {
            FB.ActivateApp();
        }
    }

    // function called when click on login button, running fb login with read permissions and then calling OnLogIn
    public void LogIn()
    {
        FB.LogInWithReadPermissions(callback: OnLogIn);
    }
	
    private void OnLogIn(ILoginResult result)
    {
        if (FB.IsLoggedIn)
        {
            AccessToken token = AccessToken.CurrentAccessToken;
            UserId.text = token.UserId;
        }
        else
        {
            Debug.Log("cancelled  LogIn");
        }
    }
}
