using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

    public GameObject[] challenges; // array of platforms being procedually generated
    public GameObject enemy;
    public float scrollSpeed ; // speed that the platforms come on screen at
    public Transform obstacleSpawner; // positions the platforms are loacted
    public float freq = 0.5f;
    float counter = 0.0f;
    bool isGameOver = false;
    int randomSpawn;
    int randomRange;
    Vector3 spawnPoint;


    // Used in initialization
    void Start () {
        CreateRandomObstacle();
        StartCoroutine(AdjustFrequency());
	}
	
	// Update checker
	void Update () {
        if (isGameOver) return;

        //GeneratesObjects as counter reaches 0
        if (counter <= 0.0f)
        {
            CreateRandomObstacle();
        }
        else {
            counter -= Time.deltaTime * freq;
        }

        //Scrolling (and destroying challenges)
        GameObject childCurrent;
        for (int i = 0; i < transform.childCount; i++) {
            childCurrent = transform.GetChild(i).gameObject;
            ScrollChallenge(childCurrent);
            if (childCurrent.transform.position.x <= -20.0f) {
                Destroy(childCurrent);
            }
        }

	}

    //Scrolling the current obstacle at a speed across the screen
    void ScrollChallenge(GameObject currentObstacle) {
        currentObstacle.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);
    }

    //using the challenges array of prefab challenges, creates new challenge at random, in the Spawn position preset.
    //created challenge is still perfectly inline with parent axis
    //sets counter to 1
    void CreateRandomObstacle() {
        randomSpawn = Random.Range(-5, 5);//random number between -5 and 4  because parses down to int
        randomRange = Random.Range(1, 3);// random range for enemy to spawn
        spawnPoint = obstacleSpawner.position;
        spawnPoint.y += randomSpawn;


        //The platforms are randomly generated platform from the array of challenges
        GameObject newChallenge = Instantiate(challenges[Random.Range(0, challenges.Length)], spawnPoint, Quaternion.identity) as GameObject;
        newChallenge.transform.parent = transform;
        //make counter =1
        counter = 1.0f;

        if (randomRange < 2)
        {
            spawnPoint.y +=  2;
            //spawn enemies
            GameObject enemySpawn = Instantiate(enemy, spawnPoint, Quaternion.identity) as GameObject;
            enemySpawn.transform.parent = transform;
        }
    }

    


    public IEnumerator AdjustFrequency()
    {
        //wait for 20 seconds an d increase speed of obsticals 
        yield return new WaitForSecondsRealtime(20f);
        freq += 0.25f;

        //wait a further 50 seconds and increase speed again
        yield return new WaitForSecondsRealtime(50f);
        freq += 0.50f;

        //wait a further 5 seconds and increase speed again
        yield return new WaitForSecondsRealtime(5f);
        freq += .05f;

    }
}
