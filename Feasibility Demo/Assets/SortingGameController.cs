using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SortingGameController : MonoBehaviour {

	public GameObject ballSpawner, scoreText;
	public int playerScore = 0;
	float spawnTimer = 0.0f;

	// Use this for initialization
	void OnEnable () 
	{
		playerScore = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawnTimer += Time.deltaTime;

		if (spawnTimer >=2.0f)
		{
			ballSpawner.GetComponent<BallSpawner>().spawnBall();
			spawnTimer = 0.0f;
		}

		Text text = scoreText.GetComponent<Text>();
		text.text = "Score: " + playerScore;
	}
}
