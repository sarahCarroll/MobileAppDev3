using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSystem : MonoBehaviour {

    public GameObject player;
    //clamp the camera to a certain position
    public float xmin;
    public float xmax;
    public float ymin;
    public float ymax;

    // Use this for initialization
    void Start () {
        //TAG the player in unity as Player which can then be accessed from any script
        player= GameObject.FindGameObjectWithTag("Player");
	}
	
	// LateUpdate gets called at the end of the update
	void LateUpdate () {
        float x = Mathf.Clamp(player.transform.position.x, xmin, xmax);
        float y = Mathf.Clamp(player.transform.position.y, ymin, ymax);

        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
