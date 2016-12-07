using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DodgingGameController : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject scoreText;

	public int playerScore;

	// Use this for initialization
	void OnEnable () 
	{
		playerScore = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Reset the player's position
		player.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

		float xPos = 0.0f;
		float yPos = 0.0f;

		// Move the player based on input
		DancePadManager dpm = eventSystem.GetComponent<DancePadManager>();
		if (dpm.upHeld())
		{
			yPos = 4.0f;
		}
		else if (dpm.downHeld())
		{
			yPos = -4.0f;
		}

		if (dpm.leftHeld())
		{
			xPos = -4.0f;
		}
		else if (dpm.rightHeld())
		{
			xPos = 4.0f;
		}

		player.transform.position = new Vector3(xPos, yPos, -1.0f);

		// Update player score
		playerScore ++;
		scoreText.GetComponent<Text>().text = "Score: " + playerScore;
	}
}
